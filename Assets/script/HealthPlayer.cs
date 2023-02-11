using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class HealthPlayer : MonoBehaviour
{

    [SerializeField] float maxHealth = 100;

    [SerializeField] public float currentHealth;
    public GameObject gameOverUi;
    public static bool gameOver;
    [SerializeField]  TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    private void Awake()
   {
       gameOver = false;
      
       
   }
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        Debug.Log("TESTING");
        scoreText.text = currentHealth.ToString();
        Debug.Log(currentHealth);
        //scoreText = currentHealth;

        if(currentHealth <= 0)
        {
           Debug.Log("Dead");
           Debug.Log("gme over ");
           gameOverUi.SetActive(true);
       }
            //instantiate losecanvas getcomponent gameoverUI
            
        }
         public void Retry()
        {
                
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
         public void QuitGame()
        {
            Application.Quit();
            Debug.Log("quitter");
        }

    }



