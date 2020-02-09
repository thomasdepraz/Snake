using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    #region Variables
    [Header("Tweaks")]
    [Range(0.05f, 2f)]
    public static float moveSpeedModifier = 1f;
    [Range(0f, 0.5f)]
    public float minDirValue = 0.1f;

    [Header("Logic")]
    public float dirY;
    public float dirX;
    private float idirX;
    private float idirY;
    private Vector2 horizontalMove;
    private Vector2 verticalMove;
    private Vector2 dir;
    private Vector2 lastDir;

    private Rigidbody2D rb;

    public static bool canMove = false;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        idirX = Input.acceleration.x;
        idirY = Input.acceleration.y;
        System.Math.Round(idirX, 2);
        System.Math.Round(idirY, 2);
        Debug.Log("idiX : " + idirX + ", idirY : " + idirY);
    }

    // Update is called once per frame
    void Update()
    {
        GetDeviceMovement();

        if (dirX < minDirValue && dirX > -minDirValue && dirY < minDirValue && dirY > -minDirValue)
        {
            //the phone rotation is to small
        }
        else
        {
            dir = new Vector2(dirX, dirY).normalized * moveSpeedModifier;
            canMove = true;
        }
    }

    private void FixedUpdate()
    {
        if (!canMove)
            return;

        Movement();
    }

    #region Methods
    private void Movement()
    {
        rb.velocity = dir;
    }


    private void GetDeviceMovement()
    {
        dirX = (Input.acceleration.x - idirX);
        dirY = (Input.acceleration.y - idirY);
        System.Math.Round(dirX, 2);
        System.Math.Round(dirY, 2);
    }
    #endregion
}
