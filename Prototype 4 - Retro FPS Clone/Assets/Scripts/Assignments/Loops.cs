using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    //public int numEwoks = 0;
    
    public int ducks = 0;
    // Start is called before the first frame update
    void Start()
    {
        // for(int i = 99; i > numEwoks; i--) {
        //     Debug.Log("There are " + i + " Ewoks on a log!");
        // }

        while(ducks < 10) {
            Debug.Log("There are " + ducks + " ducks in the pond!");
            ducks++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
