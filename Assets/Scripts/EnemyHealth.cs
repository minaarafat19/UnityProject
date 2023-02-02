using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float health = 50;
   
   public void TakeDamage(float amount, GameObject bodyPartHit)
   {
    float totalDamage = 0;

    if(bodyPartHit.tag == "Untagged")
    {
        totalDamage -= amount;
    }
    if(bodyPartHit.tag == "Head")
    {
        totalDamage -= amount*3f ;
    }
    if(bodyPartHit.tag == "Armor")
    {
        totalDamage -= amount*0.5f ;
    }
    health -= totalDamage;

    if(health <= 0)
    {
        Destroy(gameObject);
    }
   }
}
