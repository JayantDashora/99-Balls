using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TargetBall : MonoBehaviour
{

    // Variables 

    

    void Start()
    {

    }


    void Update()
    {
        
    }

    // Destroying ball when it collides with the player weapon

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Weapon")){
            Destroy(gameObject);
        }
    }



}
