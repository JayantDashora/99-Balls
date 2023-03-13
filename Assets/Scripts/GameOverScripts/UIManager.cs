using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{

    // References
    [SerializeField] private TextMeshProUGUI gameOverscoreText;
    [SerializeField] private TextMeshProUGUI gameOverstarsText;
    [SerializeField] private TextMeshProUGUI gameOverhighScoreText;


    void Update()
    {
        gameOverstarsText.text = PlayerPrefs.GetInt("stars").ToString();
        gameOverhighScoreText.text = "HIGHSCORE\n" + PlayerPrefs.GetInt("highscore").ToString();
        gameOverscoreText.text = "YOUR SCORE\n" + PlayerPrefs.GetInt("score").ToString();
    }
}
