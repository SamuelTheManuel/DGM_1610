using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float speed;
    public float waitTime;
    public float startWaitTime;
    public Transform startPoint;
    private GameObject pc;
    public float minx;
    public float miny;
    public float maxx;
    public float maxy;
    //public float range = 8.0f;

    
    // Start is called before the first frame update
    void Start()
    {
        waitTime = startWaitTime;
        pc = GameObject.FindGameObjectWithTag("Player");
        startPoint.position = new Vector2(Random.Range(minx, maxx), Random.Range(miny, maxy));
    }

    // Update is called once per frame
    void Update()
    {
        //if(Vector2.Distance(transform.position, pc.transform.position) < range){

        //transform.position = Vector2.MoveTowards(transform.position, pc.transform.position, speed * Time.deltaTime);
        //}
        if (Vector2.Distance(transform.position, startPoint.position) < 0.2f) {
            if (waitTime <= 0) {
                startPoint.position = new Vector2(Random.Range(minx, maxx), Random.Range(miny, maxy));
                waitTime = startWaitTime;
            }
            else{
                waitTime -= Time.deltaTime; 
            }
        }
    }
}
