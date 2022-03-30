using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour
{
    public string npcConv;
    public int lvl;
    public float money;
    public string gender;
    public int socialClass;
    //public int socialClass = 3;


    //FOR HOMEWORK YOU NEED 10 SWITCHES CHECKING 10 DIFFERENT VARIABLES, NOT JUST 10 CASES, 4-5 CASES PER SWITCH

    void Start() {
        switch(npcConv) {
            case "Hello":
            print("Hello good citizen! Good luck not dying!");
            break;
            case "Goodbye":
            print("Goodbye! Break a leg!");
            break;
            case "We are Being attacked!":
            print("You run away in shame you coward");
            break;
    
        }
        /*
        switch (socialClass) {
            case 5:
            Debug.Log("Hello, You're Majesty");
            break;
            case 4:
            Debug.Log("Hello young Princess!");
            break;
            case 3:
            Debug.Log("Good evening Duke");
            break;
            case 2:
            Debug.Log("good evening landowner");
            break;
            case 1:
            Debug.Log("hello peasant");
            break;
            case 0:
            Debug.Log("ARREST THAT MAN!");
            break;
            default:
            Debug.Log("I do not talk with strangers");
            break;
        }
        */
    }
}
