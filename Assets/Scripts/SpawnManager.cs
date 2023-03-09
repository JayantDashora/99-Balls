using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    // Variables

    // Spawn Points

    [SerializeField] Vector2[] spawnPoints;

    // References

    [SerializeField] private GameObject targetBall;


    void Start()
    {
        SpawnTargetBalls();
    }

    // Spawn target balls at the top of the screen 

    private void SpawnTargetBalls(){

        foreach(Vector2 pos in spawnPoints){

            int choice = Random.Range(0,2);

            if(choice == 1){
                Instantiate(targetBall,pos,transform.rotation);
            }


        }

    }




}
