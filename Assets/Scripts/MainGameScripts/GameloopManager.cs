using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameloopManager : MonoBehaviour
{

    // Variables

    [SerializeField] private float pushLength = -0.7f;

    // Spawn Points

    [SerializeField] Vector2[] spawnPoints;

    // References

    [SerializeField] private GameObject weaponSpawner;
    private WeaponSpawner weaponSpawnerScript;

    [SerializeField] private GameObject gameDataManager;
    private GameDataManager gameDataManagerScript;

    [SerializeField] private GameObject targetBall;
    [SerializeField] private Button fastForwardButton;

    private PickupSpawner pickupSpawnerScript;
    [SerializeField] private GameObject baseLine;
    private BaseLineScript baseLineScript;


    
    void Start()
    {
       weaponSpawnerScript = weaponSpawner.GetComponent<WeaponSpawner>();
       gameDataManagerScript = gameDataManager.GetComponent<GameDataManager>();
       pickupSpawnerScript = GetComponent<PickupSpawner>();
       baseLineScript = baseLine.GetComponent<BaseLineScript>();

       SpawnTargetBalls();

       // Fix bug where there is no target balls at the start 

       if(GameObject.FindWithTag("TargetBall") == null){
            SpawnTargetBalls();            
       }
       
    }

    
    void Update()
    {
        // Checks whether there are balls left on the screen after shooting and if no balls are left it enables shooting and increases score.

        if(!weaponSpawnerScript.canShoot){
            if(GameObject.FindWithTag("Weapon") == null){
                weaponSpawnerScript.canShoot = true;
                gameDataManagerScript.score++;
                fastForwardButton.gameObject.SetActive(false);
                //Slow down time scale
                Time.timeScale = 1.0f;
                PushTargetBallsAhead();
                SpawnTargetBalls();
                pickupSpawnerScript.SpawnPickup();
                baseLineScript.isFull = !baseLineScript.isFull;
                weaponSpawner.transform.position = (new Vector2(baseLineScript.firstBallXPos,weaponSpawner.transform.position.y));

                
                
            }
        }

        // Fix bug
        FixPickupsOnSameLocationBug();
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

    // Pushes target balls ahead 

    private void PushTargetBallsAhead(){

        GameObject[] targetBalls;
        targetBalls = GameObject.FindGameObjectsWithTag("TargetBall");

        GameObject[] pickUps;
        pickUps = GameObject.FindGameObjectsWithTag("Pickup");

        foreach(GameObject targetBall in targetBalls){

            // Push the object ahead on the screen for the next round

            targetBall.transform.Translate(new Vector2(0,pushLength));
            
        }

        foreach(GameObject pickup in pickUps){

            // Push the object ahead on the screen for the next round

            pickup.transform.Translate(new Vector2(0,pushLength));
            
        }


    }

    // Checking if two pickups are on the same location (bug)

    private void FixPickupsOnSameLocationBug(){

        GameObject[] allPickupsOnScreen = GameObject.FindGameObjectsWithTag("Pickup");

        for(int i = 0; i < allPickupsOnScreen.Length ; i++){
            for(int j = 0; j < allPickupsOnScreen.Length; j++){
                if((i != j) & (allPickupsOnScreen[i].transform.position == allPickupsOnScreen[j].transform.position)){
                    Destroy(allPickupsOnScreen[i]);
                    Destroy(allPickupsOnScreen[j]);
                }
            }
        }


    }

    



}
