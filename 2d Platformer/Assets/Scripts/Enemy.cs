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
    public PlayerController player;
    [Header ("Drops")]
    public GameObject lootDrop;

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

        Destroy(gameObject);

    }
    void LootDrop() {
        Instantiate(lootDrop, transform.position, Quaternion.identity);
    }
}
