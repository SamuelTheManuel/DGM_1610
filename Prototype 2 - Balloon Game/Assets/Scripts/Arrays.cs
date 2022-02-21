using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    public string[] friendNames = {"BOB", "Jim", "Sam", "Jill", "Homer"};
    // Start is called before the first frame update
    public int[] arr1 = {1,4,5,6,7};
    public int[] arr2 = {4,1,5};
    public int[] arr3= {1234,45,345};
    public float[] arr4 = {12.3f, 435.5f, 546.43f};
    public string[] lastNames = {"Smith", "Jones",  "Williams"};
    public int[] arr7 = {123, 345, 345, 765345};
    public float[] arr8 = {54445545.4545f, 456567.345f};
    public int[] arr9 = {12343, 43, 652, 234};
    public int[] arr10 = {5677, 645646};


    void Start()
    {
        foreach(string i in friendNames) {
            Debug.Log(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
