using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameoverButtons : MonoBehaviour
{

    private int mainMenuIndex = 0;

    public void MainMenuButton(){
        SceneManager.LoadScene(mainMenuIndex);
    }
}
