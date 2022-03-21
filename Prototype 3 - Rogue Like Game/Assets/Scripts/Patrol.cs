using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float speed;
    public float waitTime;
    public float startWaitTime;
    public Transform startPoint;
    public float minx;
    public float miny;
    public float maxx;
    public float maxy;

    
    // Start is called before the first frame update
    void Start()
    {
        waitTime = startWaitTime;

        startPoint.position = new Vector2(Random.Range(minx, maxx), Random.Range(miny, maxy));
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, startPoint.position, speed * Time.deltaTime);
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
