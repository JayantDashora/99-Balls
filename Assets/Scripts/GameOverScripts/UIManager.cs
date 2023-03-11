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
        gameOverhighScoreText.text = PlayerPrefs.GetInt("highscore").ToString();
        gameOverscoreText.text = PlayerPrefs.GetInt("score").ToString();
    }
}
