using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtonFunctions : MonoBehaviour
{

    private int mainGameIndex = 1;
    private int storeIndex = 3;

    public void PlayButton(){
        SceneManager.LoadScene(mainGameIndex);
    }

    public void StoreButton(){
        SceneManager.LoadScene(storeIndex);
    }

}
