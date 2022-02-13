using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    public int number1 = 23;
    public int number2 = 45;
    public float total = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        add();
        subtract();
        mult();
        div();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void add() {
        total = number1 + number2;
        Debug.Log(number1 + "+" + number2 + "="+ total);
    }
    void subtract() {
        total = number1 - number2;
        Debug.Log(number1 + "-" + number2 + "="+ total);
    }
    void mult() {
        total = number1 * number2;
        Debug.Log(number1 + "*" + number2 + "="+ total);
    }
    void div() {
        total = number1 / number2;
        Debug.Log(number1 + "/" + number2 + "="+ total);
    }
}
