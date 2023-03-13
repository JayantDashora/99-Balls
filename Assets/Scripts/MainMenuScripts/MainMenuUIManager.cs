using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainMenuUIManager : MonoBehaviour
{

    // References
    [SerializeField] private TextMeshProUGUI mainMenustarsText;
    [SerializeField] private TextMeshProUGUI mainMenuhighScoreText;


    void Update()
    {
        mainMenustarsText.text = PlayerPrefs.GetInt("stars").ToString();
        mainMenuhighScoreText.text =  "Highscore\n\n" + PlayerPrefs.GetInt("highscore").ToString();
    }
}


