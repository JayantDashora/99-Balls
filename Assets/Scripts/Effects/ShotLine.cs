using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotLine : MonoBehaviour
{

    // Variables

    private Vector3 mousePos;

    private int primaryMouseButton = 0;

    private Vector3 weaponSpawnerPos;



    // References

    private LineRenderer lineRen;
    [SerializeField] private GameObject weaponSpawner;
    private WeaponSpawner weaponSpawnerScript;

    void Start()
    {
        lineRen = GetComponent<LineRenderer>();
        weaponSpawnerScript = weaponSpawner.GetComponent<WeaponSpawner>();
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetMouseButton(primaryMouseButton) && weaponSpawnerScript.canShoot == true){

            lineRen.enabled = true;

            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            weaponSpawnerPos = weaponSpawner.transform.position;

            lineRen.SetPosition(0, new Vector3(weaponSpawnerPos.x,weaponSpawnerPos.y,0f));
            lineRen.SetPosition(1, new Vector3(mousePos.x,mousePos.y,0f));
            
        }

        else{
            lineRen.enabled = false;
        }
        

    }
}
