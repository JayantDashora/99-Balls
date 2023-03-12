using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System;

public class StoreButtonFunctions : MonoBehaviour
{

    //Variables
    private int mainMenuIndex = 0;

    // Button Functions

    public void MainMenuButton(){
        SceneManager.LoadScene(mainMenuIndex);
    }

    public void BuyWeapon(){

        int starsStore = PlayerPrefs.GetInt("stars");
        
        int price = Int32.Parse(transform.parent.GetChild(0).GetComponent<TextMeshProUGUI>().text);

        if(starsStore >= price){
            transform.parent.GetChild(1).gameObject.SetActive(true);
            PlayerPrefs.SetInt("stars",starsStore-price);
            transform.parent.GetChild(2).gameObject.SetActive(false);
            PlayerPrefs.SetInt(transform.parent.name,1);
        }
        
    }

    public void AcquireWeapon(){
        char lastChar = transform.parent.name[transform.parent.name.Length - 1];
        int index = (int)Char.GetNumericValue(lastChar);
        

        PlayerPrefs.SetInt("playerskin",index);
    }
}
