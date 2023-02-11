using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   public static GameManager instance;
   public GameObject gameOverUi;
   public GameObject WinUi;
   float score;
   public static bool gameOver;
   public static bool winScreen; 
   float currentHealth;
   [SerializeField]
   Text scoreText;



   private void Awake()
   {
       gameOver = false;
       instance = this;
       winScreen = false;
       
   }


   private void Update()
   {
     
        //var tt = GetComponent<HealthPlayer>();
        //tt.currentHealth = currentHealth;
       //go.GetComponent<EnemyAI>().player = player;
       // Debug.Log("testing!");
        //Debug.Log(currentHealth);
      
       if(gameOver)
       {
          // Debug.Log("gme over ");
           gameOverUi.SetActive(true);
       }
        
       
   }


   public void Retry()
   {
       
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);

   }

   public void AddScore(float scoreToAdd)
   {
       score += scoreToAdd;
       scoreText.text = score.ToString();

        if( score>= 50)
       {
           WinUi.SetActive(true);
           gameOverUi.SetActive(false);
           Time.timeScale= 0f;
       }

   }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("quitter");
    }
   

}
