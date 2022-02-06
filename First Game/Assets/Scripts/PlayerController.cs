using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    
    public float turnSpeed = 1f;

    public float hInput;
    public float fInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal"); 
        
        fInput = Input.GetAxis("Vertical"); 
        //makes the player move, moves based on seconds
        transform.Translate(Vector3.forward * Time.deltaTime * speed * fInput);
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * hInput);
    }
}
