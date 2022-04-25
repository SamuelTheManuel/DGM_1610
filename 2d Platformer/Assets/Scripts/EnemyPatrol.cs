using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
        public float speed;
        public float distance;
        private bool moveRight = true;
        public Transform groundDetection;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        //move the enemy to the right
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        RaycastHit2D  groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);
        if(groundInfo.collider== false) {
            if(moveRight == true) {
                //flip enemy at edge to move left
                transform.eulerAngles = new Vector3(0,180, 0);
                moveRight = false;
            }
            else {
                //flip enemy to move left at edge
                transform.eulerAngles = new Vector3(0,0,0);
                moveRight = true;
            }
        }

    }
}
