using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    //GameManager
    private GameObject manager;
    private GameManager gameManager;

    //Elements
    [Header("Elements")]
    public GameObject player;
    public CircleCollider2D playerCol;
    public Animator anim;
    private PlayerTrail playerTrail;
    public Transform head;
    private Vector3 headPoint;

    //Tweaks
    [Header("Tweaks")]
    [Range(0.05f, 0.5f)]
    public float lengthModifier = 0.05f;

    //Other
    [Header("Other")]
    public GameObject spawner;
    private PickupSpawner pickupSpawner;


    
    private int playerScore = 0;


    // Start is called before the first frame update
    void Start()
    {
        //Get GameManager
        manager = GameObject.FindGameObjectWithTag("GameManager");
        gameManager = manager.GetComponent<GameManager>();

        //Get Spawner
        pickupSpawner = spawner.GetComponent<PickupSpawner>();

        //Get player trail
        playerTrail = gameObject.GetComponent<PlayerTrail>();

        //GetHeadPosition
        headPoint = head.position;

    }

    // Update is called once per frame
    void Update()
    {
        switch(gameManager.currentState)
        {
            case GameManager.gameStates.PAUSE:
                PlayerMovement.canMove = false;
                break;

            case GameManager.gameStates.RUNNING:
                break;

            default :
                return;        
        }

        if(playerScore>=1)
        {
            playerTrail.isEmitting = true;
        }

        if(playerTrail.trailRenderer.bounds.Contains(headPoint))
        {
            Debug.Log("I am in bounds");
            //Destroy(gameObject);//FOR NOW
        }

        if (playerTrail.trailRenderer.bounds.Intersects(playerTrail.trailRenderer.bounds))
        {
            Debug.Log("Intersect with myself");
        }
    }
   


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject); //POUR L'INSTANT
        }

        if(collision.gameObject.CompareTag("Pickup"))
        {
            Pickup pickup = collision.gameObject.GetComponent<Pickup>();

            playerScore += pickup.scoreValue;
            playerTrail.trailLength += pickup.lengthModifier;
            PlayerMovement.moveSpeedModifier += pickup.speedModifier;

            Destroy(collision.gameObject);
            pickupSpawner.isPickedUp = true;
        }
    }

    public void GetAnimationEvent(string parameter)
    {
        if(parameter.Equals("spawn"))
        {
            anim.SetBool("HasSpawned", true);
            PlayerMovement.canMove = true;
        }

        if(parameter.Equals("death"))
        {
            //anim.SetBool();
            Destroy(gameObject);
        }
    }
}
