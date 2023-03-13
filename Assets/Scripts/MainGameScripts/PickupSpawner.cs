using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawner : MonoBehaviour
{
    // Variables

    [SerializeField] private GameObject[] pickups;
    [SerializeField] private int checkCount = 10;
    [SerializeField] private float yStep = -0.7f;
    [SerializeField] private float xStep = -0.65f;
    [SerializeField] private float colliderRadius = 0.4f;
    public void SpawnPickup(){
        foreach(GameObject pickup in pickups){
            int choice = Random.Range(0,10);
            
            if(choice > 4){
                for(int i = 0; i < checkCount; i++){
                    Vector2 spawnPoint = new Vector2(-2.45f + (xStep * Random.Range(1,8)),3.81f + (yStep * Random.Range(1,7)));
                    Collider2D col = Physics2D.OverlapCircle(spawnPoint,colliderRadius);

                    if(col == null){
                        Instantiate(pickup,spawnPoint,transform.rotation);
                        break;
                    }
                        


                }
                
            }
        }
    }
}
