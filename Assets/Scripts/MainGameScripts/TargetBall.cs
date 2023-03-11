using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using UnityEngine.SceneManagement;

public class TargetBall : MonoBehaviour
{
    private int gameOverScreenIndex = 2;

    // References 

    private GameObject weaponSpawner;



    void Start()
    {
        weaponSpawner = GameObject.Find("WeaponSpawner");
    }


    void Update()
    {
        // Checking Game over condition

        if(transform.position.y <= weaponSpawner.transform.position.y){
            SceneManager.LoadScene(gameOverScreenIndex);
        }

    }

    // Checking collisions

    private void OnCollisionEnter2D(Collision2D other) {
        // Destroying target ball if it collides with player weapon 
        if(other.gameObject.CompareTag("Weapon")){
            Destroy(gameObject);
        }


    }

    



}
