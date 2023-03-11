using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UITextManager : MonoBehaviour
{

    // References
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI noOfWeaponsText;
    [SerializeField] private TextMeshProUGUI starsText;
    [SerializeField] private TextMeshProUGUI highScoreText;

    [SerializeField] private GameDataManager gameDataManager;
    private GameDataManager gameDataManagerScript;


    void Start()
    {
        gameDataManagerScript = gameDataManager.GetComponent<GameDataManager>();
    }


    void Update()
    {
        scoreText.text = gameDataManagerScript.score.ToString();
        noOfWeaponsText.text = gameDataManagerScript.noOfWeapons.ToString();
        starsText.text = gameDataManagerScript.stars.ToString();
        highScoreText.text = gameDataManagerScript.highScore.ToString();
    }
}
