using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDataManager : MonoBehaviour
{

    // Stats 

    [HideInInspector] public int noOfWeapons = 1;
    [HideInInspector] public int score = 0;
    [HideInInspector] public int stars;
    [HideInInspector] public int highScore = 0;

    void Start()
    {
        // Loading the stars value at the start of the level.
        stars = PlayerPrefs.GetInt("stars");

        // Loading the highscore value at the start of the level.
        highScore = PlayerPrefs.GetInt("highscore");
    }


    void Update()
    {

        // DATA PERSISTENCE 

        // Saving stars in the registry 
        PlayerPrefs.SetInt("stars", stars);
        PlayerPrefs.Save();

        // Saving highscore in the registry 
        if(score > highScore){
            PlayerPrefs.SetInt("highscore", score);
            PlayerPrefs.Save();
        }       
    }
}
