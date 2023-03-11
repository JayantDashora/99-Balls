using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{

    // References 

    private GameObject gameDataManager;
    private GameDataManager gameDataManagerScript;

    void Start()
    {
       gameDataManager = GameObject.Find("GameDataManager");
       gameDataManagerScript = gameDataManager.GetComponent<GameDataManager>();

    }


    void Update()
    {
        
    }

    // Detecting collision between weapon and pickup

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Weapon")){
            gameDataManagerScript.stars++;
            Destroy(gameObject);
        }
    }




    
}
