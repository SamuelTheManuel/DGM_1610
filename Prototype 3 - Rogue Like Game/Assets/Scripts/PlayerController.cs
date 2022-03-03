using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed = 5f; //speed at which the player moves

    private Rigidbody2D rb; // store the reference 2D rigidbody

    Vector2 movement; //store the players x,y position for movement

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal"); // input for left right movement
        movement.y = Input.GetAxis("Vertical"); // input for up down movement
    
    }
    void FixedUpdate(){
        //apply physics and move character
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);
    }
}
