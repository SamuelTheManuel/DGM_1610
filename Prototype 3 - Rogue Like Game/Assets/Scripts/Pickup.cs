using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public enum PickupType {Key, Coin, Gem};
    public PickupType currentPickup;
    public int pickupAmount;

    private PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            switch (currentPickup) {
            case PickupType.Key:
            playerController.key = pickupAmount;
            Debug.Log("You have picked up a key");
            break;
            case PickupType.Coin:
            playerController.coins += pickupAmount;
            Debug.Log("You have picked up " + pickupAmount + " coins!");
            break;
            case PickupType.Gem:
            playerController.gems = pickupAmount;
            Debug.Log("You picked up " + pickupAmount + " gem!");
            break;
            }
            Destroy(gameObject);

        }
    }
    
        
    
}
