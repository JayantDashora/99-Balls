using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSpawner : MonoBehaviour
{
    // Variables
    private int primaryMouseButton = 0;
    [HideInInspector] public Vector2 finalForceDirection;
    

    // Variables visible in the inspector
    [SerializeField] private Vector2 forceDirection;
    [SerializeField] private float timeDurationBetweenWeaponSpawns = 1.0f;
    [SerializeField] private Vector3 normalScale = new Vector3(0.4f,0.4f,0.4f);
    [SerializeField] private Vector3 pressedScale = new Vector3(0.35f,0.35f,0.35f);

    // Public Variables

    [HideInInspector] public bool canShoot = true;

    // References
    [SerializeField] private GameObject weapon;
    [SerializeField] private GameObject gameDataManager;
    private GameDataManager gameDataManagerScript;



    void Start()
    {
        gameDataManagerScript = gameDataManager.GetComponent<GameDataManager>();
    }


    void Update()
    {

        if(canShoot == true){
            DragWeapon();
            ReleaseWeapon();
        }



    }

    // When player drags the ball to aim

    private void DragWeapon(){

        if(Input.GetMouseButton(primaryMouseButton)){

            transform.localScale = pressedScale;
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            forceDirection = ((Vector2)transform.position-mousePos).normalized;

        }
    }

    // When player releases button to shoot the ball
    private void ReleaseWeapon(){

        if(Input.GetMouseButtonUp(primaryMouseButton)){


            finalForceDirection = forceDirection;
            transform.localScale = normalScale;
            canShoot = false;

            StartCoroutine(SpawnWeapon());
            

        }        
    }


    // Spawn weapon 

    private IEnumerator SpawnWeapon(){

        for(int i = 0; i < gameDataManagerScript.noOfWeapons;i++){    
            Instantiate(weapon,transform.position,transform.rotation);
            yield return new WaitForSeconds(timeDurationBetweenWeaponSpawns);
        }

    }



    



}
