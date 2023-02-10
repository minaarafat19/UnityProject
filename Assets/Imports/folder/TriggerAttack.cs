using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAttack : MonoBehaviour
{

    [SerializeField] float damageAmount = 30f;

    private void OnTriggerEnter(Collider player)
    {
        // SI C'EST LE PLAYER
        if(player.tag == "Player")
        {
            player.GetComponent<HealthPlayer>().TakeDamage(damageAmount);
        }
    }



}
