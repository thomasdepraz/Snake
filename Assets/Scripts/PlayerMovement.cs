using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    #region Variables
    [Header("Tweaks")]
    [Range(0.05f, 2f)]
    public float moveSpeedModifier = 0.5f;

    [Header("Logic")]
    public float dirY;
    public float dirX;

    private Rigidbody2D rb;

    static bool canMove;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        GetDeviceMovement();

        if (!canMove)
        {
            rb.velocity = Vector2.zero;
        }
    }

    private void FixedUpdate()
    {
        Movement();
    }

    #region Methods
    private void Movement()
    {
        if(canMove)
        {
           rb.velocity = new Vector2(rb.velocity.x + dirX, rb.velocity.y + dirY);
        }

        /*if(-0.1f < dirX && dirX < 0.1f && -0.1f < dirY && dirY < 0.1f)
        {
            canMove = false;
        }*/

        else
        {
            canMove = true;
            Debug.Log(canMove);
        }
    }

    private void GetDeviceMovement()
    {
        dirX = Input.acceleration.x * moveSpeedModifier;
        dirY = Input.acceleration.y * moveSpeedModifier;
    }
    #endregion
}
