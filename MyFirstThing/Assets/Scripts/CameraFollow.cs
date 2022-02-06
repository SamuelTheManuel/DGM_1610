using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    //workingversion
    private Vector3 offset = new Vector3(0, 1, -3);


    void Update()
    {
        //follow player
        transform.position = player.transform.position + offset;
    }
}
