using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// above lines are libraries full of commands that we can use


public class variables : MonoBehaviour //"variables" needs to be the same name as the file name
{
    //monoBehavior is a library?
    public int money = 0;//declaration of variable
    public float change = .75f;//needs an f or else it doesnt know what it is
    public bool isDay = true;//booleans are true or false
    public string message = "hello there";
    public const int customerID = 345;

    float waterBottle = 0.35f;


    // Start is called before the first frame update, happens once when the program is being run
    void Start()
    {
        money = 100;
        Debug.Log("there is $" + money + " money");//Debug.Log is more useful but for now print does essentially the same thing
        
    }

    // Update is called once per frame
    //main game loop
    void Update()
    {
        waterBottle = 1.00f;
        if (money == 120)
        {
            Debug.Log("You win the Game!");
        }
        if (isDay){
            Debug.Log("It is daytime!");
            Debug.Log("water remaining: " + waterBottle);
            isDay = false;
        }
    }
}
