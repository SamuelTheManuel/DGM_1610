using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class if_conditionals : MonoBehaviour
{
    // public string lightColor;

    // public string weather;

    public int height;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        // if (lightColor == "Red") {
        //     Debug.Log("The Light is " + lightColor + " STOP!!!");
        // }
        // else if (lightColor == "Yellow") {
        //     Debug.Log("The light is " + lightColor + " SLOW DOWN!!");
        // }
        // else if (lightColor == "Green") {
        //     Debug.Log("The light is " + lightColor + " GO FASTER!!!");
        // }
        // else {
        //     Debug.Log("The light is Broken, call the cops");
        // }

        // if(weather == "rain" || weather == "snowy") {
        //     Debug.Log("the weather is bad");
        // }
        // else if (weather == "sunny" || weather == "partly cloudy") {
        //     Debug.Log("the weather is good");
        // }

        if (height >= 3 && height <= 10) {
            Debug.Log("you can ride this coaster");
        }
        else {
            Debug.Log("you cannot ride this coaster");
        }
    }
}

