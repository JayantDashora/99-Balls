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

    }

    // Checking collisions

    private void OnCollisionEnter2D(Collision2D other) {

        // Weapon gets destroyed if it collides with base
        if(other.gameObject.name == "Base"){
            Destroy(gameObject);
        }


    }



}