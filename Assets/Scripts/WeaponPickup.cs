using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickup : MonoBehaviour
{

    // References 

    private GameObject gameDataManager;
    private GameDataManager gameDataManagerScript;

    void Start()
    {
       gameDataManager = GameObject.Find("GameDataManager");
       gameDataManagerScript = gameDataManager.GetComponent<GameDataManager>();

    }

    // Detecting collision between weapon and pickup

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Weapon")){
            gameDataManagerScript.noOfWeapons++;
            Destroy(gameObject);
        }
    }
}
