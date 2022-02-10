using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int ScoreToGive = 100; 
    public int clickToPop = 3;

    public float scaleToIncrease = 0.25f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown() {
        //reduce clicks by 1
        clickToPop -= 1;
        //change the scale
        transform.localScale += Vector3.one * scaleToIncrease;
        if (clickToPop == 0) {
            Debug.Log("the balloon has popped");
            
            //transform.localScale = Vector3.zero;

            Destroy(gameObject);
        }
    }
}
