using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAttack : MonoBehaviour
{
    [SerializeField] float damageAmount = 30f;

    private void OnTriggerEnter(Collider Player)
    {
        if(Player.tag == "Player")
        {
            Player.GetComponent<HealthPlayer>().TakeDamage(damageAmount);
        }
    }



}
