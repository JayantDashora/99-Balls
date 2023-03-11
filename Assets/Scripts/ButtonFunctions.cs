using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFunctions : MonoBehaviour
{

    // Variables 

    [SerializeField] private float fastForwardRate = 2.0f;

    // References
    [SerializeField] private GameObject weaponSpawner;
    private WeaponSpawner weaponSpawnerScript;


    void Start() {
        weaponSpawnerScript = weaponSpawner.GetComponent<WeaponSpawner>(); 
    }
    
    public void FastForward(){
        if(!weaponSpawnerScript.canShoot){
            // Fast forward 
            Time.timeScale = fastForwardRate;
        }
    }
}
