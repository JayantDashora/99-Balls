using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{

    // Variables
    [SerializeField] private int forceFactor = 8;
    [SerializeField] private Sprite[] weaponSkinArray;
      

    // References

    private Rigidbody2D weaponRb;
    private GameObject weaponSpawner;
    private WeaponSpawner weaponSpawnerScript;

    private GameObject gameDataManager;
    private GameDataManager gameDataManagerScript;
    private SpriteRenderer weaponSpriteRenderer;

    private TrailRenderer trailRen;




    void Start()
    {

        

        weaponSpawner = GameObject.Find("WeaponSpawner");


        weaponRb = GetComponent<Rigidbody2D>();
        weaponSpawnerScript = weaponSpawner.GetComponent<WeaponSpawner>();

        gameDataManager = GameObject.Find("GameDataManager");
        gameDataManagerScript = gameDataManager.GetComponent<GameDataManager>();

        weaponRb.AddForce(forceFactor*weaponSpawnerScript.finalForceDirection,ForceMode2D.Impulse);

        // Setting the player skin to the one they have chosen

        weaponSpriteRenderer = GetComponent<SpriteRenderer>();
        weaponSpriteRenderer.sprite = weaponSkinArray[gameDataManagerScript.playerSkinIndex];

        // Setting weapon bal trail to match the color of the ball

        trailRen = GetComponent<TrailRenderer>();

        if(gameDataManagerScript.playerSkinIndex == 1){
            trailRen.startColor = new Color(1, 0, 0, 1);
            trailRen.endColor = new Color(0, 0, 0, 0);
        }
        else if(gameDataManagerScript.playerSkinIndex == 2){
            trailRen.startColor = new Color(1, 0.92f, 0.016f, 1);
            trailRen.endColor = new Color(0, 0, 0, 0);
        }
        else if(gameDataManagerScript.playerSkinIndex == 3){
            trailRen.startColor = new Color(1f, 0.454f, 0.0156f,1);
            trailRen.endColor = new Color(0, 0, 0, 0);
        }
        else if(gameDataManagerScript.playerSkinIndex == 4){
            trailRen.startColor = new Color(0, 0, 1, 1);
            trailRen.endColor = new Color(0, 0, 0, 0);
        }


    }

    // Checking collisions

    private void OnCollisionEnter2D(Collision2D other) {

        // Weapon gets destroyed if it collides with base
        if(other.gameObject.name == "Base"){

            Destroy(gameObject);
        }


    }



}