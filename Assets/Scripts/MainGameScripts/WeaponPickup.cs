using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WeaponPickup : MonoBehaviour
{

    // References 

    private GameObject gameDataManager;
    private GameDataManager gameDataManagerScript;

    private GameObject weaponSpawner;





    void Start()
    {
       weaponSpawner = GameObject.Find("WeaponSpawner");
       gameDataManager = GameObject.Find("GameDataManager");
       gameDataManagerScript = gameDataManager.GetComponent<GameDataManager>();



    }

    void Update(){
        // Checking Game over condition

        if(transform.position.y <= weaponSpawner.transform.position.y){
            Destroy(gameObject);
        }
        
    }

    // Detecting collision between weapon and pickup

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Weapon")){
            gameDataManagerScript.noOfWeapons++;
            Destroy(gameObject);
        }
    }
}
