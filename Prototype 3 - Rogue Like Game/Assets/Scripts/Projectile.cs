using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 1;
    private Transform player;
    private PlayerController pc;
    private Vector3 dir;

   // private Vector2 target;
    //private Vector3 dir;
    //private float angle;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        pc = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();

 //       target = new Vector2(player.position.x, player.position.y);
        dir = (player.position - transform.position).normalized;

    }

    // Update is called once per frame
    void Update()
    {
       transform.position += dir * speed * Time.deltaTime;
        // if (transform.position.x == target.x && transform.position.y == target.y) {
        //     DestroyProjectile();
        // }

    }
    void DestroyProjectile() {
        Destroy(gameObject);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player")) {
            pc.TakeDamage(1);
            DestroyProjectile();
        }
        if (other.CompareTag("Walls")) {
            DestroyProjectile();
        }
        

    }
}
