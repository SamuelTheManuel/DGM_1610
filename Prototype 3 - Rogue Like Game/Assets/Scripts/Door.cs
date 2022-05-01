using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
        private PlayerController playerController;
        public int numLocks = 1;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player") && playerController.key >= numLocks) {
            playerController.key -= numLocks;
            playerController.UpdateInv();
            Debug.Log("The door has opened");
            Destroy(gameObject);
        }
        else {
            Debug.Log("The door is locked, go get a key");
        }
    }
}
