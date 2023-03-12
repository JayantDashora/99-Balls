using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDManager : MonoBehaviour
{

    // Variables

    [SerializeField] private float introSeqLength = 2.5f;

    // References 

    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject introHUD;


    void Start()
    {

        StartIntroSeq();

        
    }

    void Update()
    {
        
    }

    private void StartIntroSeq(){
        introHUD.SetActive(true);
        mainMenu.SetActive(false);
        Invoke("EndIntroSeq",introSeqLength);
    }

    private void EndIntroSeq(){

        introHUD.SetActive(false);       
        mainMenu.SetActive(true);
    }
}
