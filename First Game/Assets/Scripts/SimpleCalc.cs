using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCalc : MonoBehaviour
{
//AccessModifier datatype name;
    public int numberA = 10;
    public int numberB = 123;
    public int numberC = 432;
    

    // Start is called before the first frame update
    void Start()
    {
        int total;
        total = numberA + numberB + numberB;
        Debug.Log(total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
