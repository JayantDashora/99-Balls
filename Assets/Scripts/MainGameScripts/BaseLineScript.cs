using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseLineScript : MonoBehaviour
{

    // Variables

    public float firstBallXPos;
    public bool isFull;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Weapon") && !isFull){
            firstBallXPos = other.gameObject.transform.position.x;
            isFull = true;

        }
    }
}
