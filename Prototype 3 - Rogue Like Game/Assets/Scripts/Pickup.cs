using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public enum PickupType {Key, Coin, Health};
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
            playerController.key = pickupAmount;//call update ui func
            playerController.UpdateInv();
            Debug.Log("You have picked up a key");
            break;
            case PickupType.Coin:
            playerController.coins += pickupAmount;
            playerController.UpdateInv();//call update ui func

            Debug.Log("You have picked up " + pickupAmount + " coins!");
            break;
            case PickupType.Health:
            playerController.heal(pickupAmount);

            Debug.Log("You picked up " + pickupAmount + " health!");
            break;
            }
            Destroy(gameObject);

        }
    }
    
        
    
}
