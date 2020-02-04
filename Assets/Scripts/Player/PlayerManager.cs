using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{ 
    [Header("Elements")]
    public GameObject player;
    public CircleCollider2D playerCol;
    public Animator anim;
    public GameObject spawner;
    private PickupSpawner pickupSpawner;

    private int playerScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        pickupSpawner = spawner.GetComponent<PickupSpawner>();
    }

    // Update is called once per frame
    void Update()
    {

    }
   
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject); //POUR L'INSTANT
        }

        if(collision.gameObject.CompareTag("Pickup"))
        {
            Destroy(collision.gameObject);
            pickupSpawner.isPickedUp = true;
            playerScore++;
            Debug.Log(playerScore);
        }
    }

    public void GetAnimationEvent(string parameter)
    {
        if(parameter.Equals("spawn"))
        {
            anim.SetBool("HasSpawned", true);
            PlayerMovement.canMove = true;
        }
    }
}
