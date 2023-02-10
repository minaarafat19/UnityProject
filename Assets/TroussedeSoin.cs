using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrousseDeSoin : MonoBehaviour
{
    [SerializeField]
    float healAmount = 5;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Player.instance.GetComponent<HealthPlayer>().TakeDamage(healAmount);
            Destroy(gameObject);
        }
    }
 
}
