using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{

    // Variables
    [SerializeField] private int forceFactor = 8;    

    // References

    private Rigidbody2D weaponRb;
    [SerializeField] private GameObject weaponSpawner;
    private WeaponSpawner weaponSpawnerScript;



    void Start()
    {

        weaponSpawner = GameObject.Find("WeaponSpawner");


        weaponRb = GetComponent<Rigidbody2D>();
        weaponSpawnerScript = weaponSpawner.GetComponent<WeaponSpawner>();

        weaponRb.AddForce(forceFactor*weaponSpawnerScript.finalForceDirection,ForceMode2D.Impulse);

    }

    // Checking collisions

    private void OnCollisionEnter2D(Collision2D other) {

        // Weapon gets destroyed if it collides with base
        if(other.gameObject.name == "Base"){
            Destroy(gameObject);
        }


    }



}