using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour
{

    void Update()
    {
        if(PlayerPrefs.GetInt(transform.name) == 1){
            transform.GetChild(1).gameObject.SetActive(true);
            transform.GetChild(2).gameObject.SetActive(false);            
        }
    }

}
