using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header ("Player Health")]
    public int curHP;
    public int maxHP;
    public HealthBar healthbar;








    [Header ("Player Movement")]
    public float moveSpeed = 5f; //speed at which the player moves

    private Rigidbody2D rb; // store the reference 2D rigidbody

    private Vector2 movement; //store the players x,y position for movement
    private Vector2 direction;

    [Header ("Player Combat")]
    public int damage;
    public float attackRange; // ranmge at which the player can attack
    public float attackRate;
    private float lastAttackTime;
    public LayerMask EnemyLayer;




    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        curHP = maxHP;
        healthbar.SetHealth(maxHP);

    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal"); // input for left right movement
        movement.y = Input.GetAxis("Vertical"); // input for up down movement
        if (Input.GetKeyDown(KeyCode.Space)) {
            if (Time.time - lastAttackTime >= attackRate)  {
                Attack();
            }
        }
    
    }
    void FixedUpdate(){
        //apply physics and move character
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);
        UpdateDirection();
    }

    void UpdateDirection() {
        Vector2 vel = new Vector2(movement.x, movement.y);
        if(vel.magnitude != 0) {
            direction = vel;
        }
        rb.velocity = vel * moveSpeed;

    }
    void Attack() {
        lastAttackTime = Time.time;
        //raycast using the enemyLayer

        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, attackRange, EnemyLayer);

        if(hit.collider != null) {
            hit.collider.GetComponent<Enemy>()?.TakeDamage(damage);
            

    
        }
    }
    public void TakeDamage(int damage) {
        curHP -=damage;
        healthbar.SetHealth(curHP);
        if (curHP <= 0) {
            Die();
        }
    }
    void Die() {
        Debug.Log("You Died");
    }
}
