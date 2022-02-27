using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] balloonPrefabs;
    public float startDelay = 0.2f;
    public float spawnInterval = 0.2f;
    //public int balloonIndex;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBalloon", startDelay, spawnInterval);
    }

    // Update is called once per frame
   
    void SpawnRandomBalloon() {
        Vector3 spawnPos = new Vector3(Random.Range(0,10),10, 0);
        //pick random balloon from array
        int balloonIndex = Random.Range(0, balloonPrefabs.Length);
        //code below is different from the class code
        Instantiate(balloonPrefabs[balloonIndex], spawnPos, Quaternion.identity); //spawns the balloon (what, pos, rotation)
    }
}
