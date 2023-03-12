using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunctions : MonoBehaviour
{

    // Variables 

    [SerializeField] private float fastForwardRate = 2.0f;


    // References
    [SerializeField] private GameObject weaponSpawner;
    private WeaponSpawner weaponSpawnerScript;



    void Start() {
        weaponSpawner = GameObject.Find("WeaponSpawner");
        weaponSpawnerScript = weaponSpawner.GetComponent<WeaponSpawner>(); 


    }
    
    public void FastForward(){
        if(!weaponSpawnerScript.canShoot){
            // Fast forward 
            Time.timeScale = fastForwardRate;
        }
    }

 
}
