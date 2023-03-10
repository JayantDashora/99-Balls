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

    // Weapon gets destroyed if it collides with base

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.name == "Base"){
            Destroy(gameObject);
        }
    }

}
