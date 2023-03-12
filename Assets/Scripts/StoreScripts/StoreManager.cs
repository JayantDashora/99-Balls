using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System;

public class StoreManager : MonoBehaviour
{

    // References
    [SerializeField] private TextMeshProUGUI storeStarsText;
    void Update()
    {
       storeStarsText.text = PlayerPrefs.GetInt("stars").ToString(); 
    }





}
