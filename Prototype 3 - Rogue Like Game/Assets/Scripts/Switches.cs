using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour
{
    public string npcConv;
    public int lvl;
    public float money;
    public string height;
    public int socialClass;
    public int width;
    public string firstName;
    public bool isOpen;
    public int exp;
    public string response;

    


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
        
        switch (lvl) {
            case 1:
            print("you are a noob");
            break;
            case 2:
            print("You are less of a noob");
            break;
        }
        switch(money) {
            case 0:
            print("YOU are broke");
            break;
            case 1000:
            print("You have enough money for now");
            break;
        }
        switch(height) {
            case "0":
            print("YOu are impossibly short");
            break;
            case "4":
            print("You are a good size for a dwarf");
            break;
            case"7":
            print("Doorways must be a pain for you, huh?");
            break;

        }
        switch (width) {
            case 50:
            print("YOu are too wide to fit");
            break;
            case 25:
            print("you should squeexe through just fine");
            break;
        }

        switch (socialClass) {
            case 5:
            Debug.Log("Hello, You're Majesty");
            break;
            case 4:
            Debug.Log("Hello young Princess!");
            break;

        }
        switch (firstName) {
            case "Sam":
            print("Your first name is Sam");
            break;
            case "Bill":
            print("Your first name is Bill");
            break;
        
        }
        switch (isOpen) {
            case true:
            print("The door is open");
            break;
            case false:
            print("the door is closed");
            break;
        }
        switch (exp) {
            case 100:
            print ("you can level up now");
            break;
            default:
            print("you cannot level up yet");
            break;
        }
        switch (response) {
            case "i will fight":
            print("great, we need the help we can get");
            break;
            case "not today":
            print("well thanks for nothing");
            break;
        }
        
    }
}
