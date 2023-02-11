using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class Pistol : MonoBehaviour
{
    [SerializeField] GameObject firepoint;
    [SerializeField] float pistolDamage = 15f;
     public GameObject WinUi;
     
     public static bool winScreen; 
     float score;
    [SerializeField] TextMeshProUGUI scoreText;


    [SerializeField] GameObject hitFxPrefab;

    [SerializeField] int bulletMax = 7;

    [SerializeField] TextMeshProUGUI currentAmmoUI;
    [SerializeField] TextMeshProUGUI maxAmmoUI;
    

    int currentBullet;

    private void Start()
    {
        currentBullet = bulletMax;


        currentAmmoUI.text = currentBullet.ToString("00");
        maxAmmoUI.text = bulletMax.ToString("00");

    }


    public void Tir()
    {

        // SI JE N'AI PLUS DE BALLE
        if (currentBullet <= 0)
        {

            // JE NE FAIS RIEN
            return;

        }

        currentBullet--;
        currentAmmoUI.text = currentBullet.ToString("00");

        RaycastHit hitInfo;

        bool hit = Physics.Raycast(firepoint.transform.position, firepoint.transform.forward, out hitInfo);


        // PARTICLE
        if(hit)
        {
            GameObject fx = Instantiate(hitFxPrefab, hitInfo.point, Quaternion.Euler(firepoint.transform.forward));
            Destroy(fx, 5f);
        }


        // POUR LES DESTRUCTIBLES
        if(hit && hitInfo.collider.tag == "Destructible")
        {

            Rigidbody rb = hitInfo.transform.gameObject.GetComponent<Rigidbody>();
            rb.AddForceAtPosition(firepoint.transform.forward * 10, hitInfo.point, ForceMode.Impulse);
        }


        // POUR LES ENEMY
        if (hit && hitInfo.transform.gameObject.tag == "Enemy")
        {
            EnemyHealth eh = hitInfo.transform.gameObject.GetComponent<EnemyHealth>();
            eh.TakeDamage(pistolDamage, hitInfo.collider.gameObject);
        }


    }
    public void AddScore(float scoreToAdd)
    {
       score += scoreToAdd;
       scoreText.text = score.ToString();

        if( score>= 50)
       {
           WinUi.SetActive(true);
           Debug.Log("Testing WIN screen !");
           //gameOverUi.SetActive(false);
           Time.timeScale= 0f;
       }

    }

    public void Reload()
    {
        currentBullet = bulletMax;
        currentAmmoUI.text = currentBullet.ToString("00");
    }
}
