using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header ("PlayerStats")]
    public float speed;
    public float jumpHeight;
    private bool isGrounded;
    public int curHP;
    public int maxHP;
    public HealthBar healthBar;
    private Rigidbody2D rb;
    [Header ("GroundCheck")]
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private float moveVelocity;
    public AudioClip marker;
    private AudioSource source;



    // Start is called before the first frame update
    void Start()
    {
        isGrounded = true;
        rb = GetComponent<Rigidbody2D>();
        source = GetComponent<AudioSource>();
        curHP = maxHP;
        healthBar.SetHealth(maxHP);

    }

     void Update()
    {
        //non stick player
        moveVelocity = 0f;
        //groundcheck sensor
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
        while (!isGrounded) {
            
        }
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


    public void Jump() {
        rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
        source.PlayOneShot(marker, 0.75f);//second var is volume
    }
    public void TakeDamage(int damage) {
        curHP -= damage;
        if (curHP <= 0) {
            Die();
        }
    }
    void Die() {
        Debug.Log("You have died");
    }
}
