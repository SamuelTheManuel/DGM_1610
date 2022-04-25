using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header ("PlayerStats")]
    public float speed;
    public float jumpHeight;
    private bool isGrounded;
    private Rigidbody2D rb;
    [Header ("GroundCheck")]
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private float moveVelocity;



    // Start is called before the first frame update
    void Start()
    {
        isGrounded = true;
        
        rb = GetComponent<Rigidbody2D>();
    }

     void Update()
    {
        //non stick player
        moveVelocity = 0f;
        //groundcheck sensor
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

        if(Input.GetKey(KeyCode.D)) {
            moveVelocity  = speed;
        }
        if(Input.GetKey(KeyCode.A)) {
            moveVelocity  = -speed;
        }
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded) {
            Jump();
        }
        //move player left and right
        rb.velocity = new Vector2(moveVelocity, rb.velocity.y);
    }
    // Update is called once per frame
    // void Update()
    // {


    // }
    public void Jump() {
        rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
    }
}
