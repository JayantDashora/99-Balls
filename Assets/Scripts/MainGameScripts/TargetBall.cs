using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TargetBall : MonoBehaviour
{
    // Variables
    private int gameOverScreenIndex = 2;
    private int hitLimit;

    // References 

    private GameObject weaponSpawner;
    [SerializeField] private TextMeshProUGUI hitLimitText;

    private GameObject gameDataManager;
    private GameDataManager gameDataManagerScript;
    [SerializeField] private ParticleSystem explosionParticleSystem;






    void Start()
    {
        weaponSpawner = GameObject.Find("WeaponSpawner");
        gameDataManager = GameObject.Find("GameDataManager");
        gameDataManagerScript = gameDataManager.GetComponent<GameDataManager>();

        // Generating random value for the target balls.
        // Generally the maximum value is less than or equal to 2*score.

        hitLimit = Random.Range(1,2*gameDataManagerScript.score);
    }


    void Update()
    {
        // Checking Game over condition

        if(transform.position.y <= weaponSpawner.transform.position.y){
            SceneManager.LoadScene(gameOverScreenIndex);
        }

        // Ball destruction condition

        if(hitLimit <= 0){

            Instantiate(explosionParticleSystem,transform.position,transform.rotation);
            Destroy(gameObject,0.05f);
            
            
        }


        // Target Ball Health

        BallTextSetup();

    }

    // Checking collisions

    private void OnCollisionEnter2D(Collision2D other) {
        // Destroying target ball if it collides with player weapon 
        if(other.gameObject.CompareTag("Weapon")){
            hitLimit--;
            
        }


    }

    private void BallTextSetup(){

        // Fixing the position of the text to the ball  
        (transform.GetChild(0).GetChild(0)).position = Camera.main.WorldToScreenPoint(transform.position);
        //Updating hitlimit text on the screen
        hitLimitText.text = hitLimit.ToString();

    }


}   
