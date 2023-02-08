using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float health = 50f;

    public void TakeDamage(float amount, GameObject bodyPartHit)
    {
        float totalDamage = 0;


        switch(bodyPartHit.tag)
        {
            case "Untagged":
                totalDamage = amount;
                break;

            case "Head":
                totalDamage = amount * 3f;
                break;

            case "Armor":
                totalDamage = amount * .5f;
                break;

            default:
                break;

        }




        health -= totalDamage;

        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
