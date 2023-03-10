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

    // Checking collisions

    private void OnCollisionEnter2D(Collision2D other) {
        // Destroying target ball if it collides with player weapon 
        if(other.gameObject.CompareTag("Weapon")){
            Destroy(gameObject);
        }
    }



}
