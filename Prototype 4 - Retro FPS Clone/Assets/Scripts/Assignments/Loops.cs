using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    //loop vars
    public int numEwoks = 10;
    public int numJedi = 10;
    public int sith = 2;
    public int ships = 100;
    public int planets = 0;

    //while vars
    
    public int ducks = 0;
    public int swans = 0;
    public int bears = 0;
    public int giants = 0;
    public int dragons = 0;

    
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < numEwoks; i++) {
            Debug.Log("There are " + i + " Ewoks on a log!");
        }
        for (int i=0; i < numJedi; i++ ){
            Debug.Log("There are " + i + " Jedi remaining!");
        }
        for (int i=0; i < sith; i++ ){
            Debug.Log("There are " + i + " Sith!");
        }
        for (int i=0; i < ships; i++ ){
            Debug.Log("There are " + i + " ships remaining!");
        }
        for (int i=0; i < planets; i++ ){
            Debug.Log("There are " + i + " Planets in this system");
        }

        while(ducks < 10) {
            Debug.Log("There are " + ducks + " ducks in the pond!");
            ducks++;
        }
        while(swans < 10) {
            Debug.Log("There are " + swans + " swans in the pond!");
            swans++;
        }
        while(bears < 10) {
            Debug.Log("There are " + bears + " bears eating swans!");
            bears++;
        }
        while(giants < 10) {
            Debug.Log("There are " + giants + " giants smacking the bears!");
            giants++;
        }
        while(dragons < 10) {
            Debug.Log("There are " + dragons + " dragons eating the giants!");
            dragons++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
