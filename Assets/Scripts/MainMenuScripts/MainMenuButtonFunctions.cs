using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtonFunctions : MonoBehaviour
{

    private int mainGameIndex = 1;

    public void PlayButton(){
        SceneManager.LoadScene(mainGameIndex);
    }

}
