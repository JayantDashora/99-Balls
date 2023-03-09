using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{

    // Variables

    private int primaryMouseButton = 0;
    private Vector2 forceDirection;
    [SerializeField] private int forceFactor;

    private Vector3 normalScale = new Vector3(0.4f,0.4f,0.4f);
    private Vector3 pressedScale = new Vector3(0.35f,0.35f,0.35f);

    

    // References

    // Player weapons's rigidbody

    private Rigidbody2D weaponRb;



    void Start()
    {
        weaponRb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {

        DragWeapon();
        ReleaseWeapon();

    }

    private void DragWeapon(){

        if(Input.GetMouseButton(primaryMouseButton)){

            transform.localScale = pressedScale;
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            forceDirection = ((Vector2)transform.position-mousePos).normalized;

        }
    }

    private void ReleaseWeapon(){

        if(Input.GetMouseButtonUp(primaryMouseButton)){

            weaponRb.AddForce(forceDirection*forceFactor,ForceMode2D.Impulse);
            transform.localScale = normalScale;
            
        }        
    }





}
