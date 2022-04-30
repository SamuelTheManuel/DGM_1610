using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header ("Enemy Health")]
    public int currHP;
    public int maxHP;

    [Header ("Enemy Attack")]
    public int damage;
    public float attackRange;
    public float attackRate;
    private float lastAttackTime;
    public float range = 5.0f; //aggro range
    public float speed = 2.0f;
    public PlayerController player;
    [Header ("Drops")]
    public GameObject lootDrop;
    public int healAmount = 4;

    //public GameObject healthDrop;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - lastAttackTime >= attackRate && Vector2.Distance(transform.position, player.transform.position) < attackRange) {
            Attack();
        }
        if (Vector2.Distance(transform.position, player.transform.position) < range) {//aggro range
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        } 
    }
    public void TakeDamage(int damage) {
        currHP -= damage;
        
        if (currHP <= 0) {
            Die();
            LootDrop();
        }

    }

    void Attack() {
        lastAttackTime = Time.time;
        player.TakeDamage(damage);

    }

    void Die() {
        player.heal(healAmount);
        Destroy(gameObject);

    }
    void LootDrop() {
        Instantiate(lootDrop, transform.position, Quaternion.identity);
        //Instantiate(healthDrop, transform.position, Quaternion.identity);
    }
}
