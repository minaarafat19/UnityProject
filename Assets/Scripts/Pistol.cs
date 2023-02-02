using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : MonoBehaviour
{

    [SerializeField] GameObject firepoint ;
    [SerializeField] float pistolDamage;
  
  public void Tir(){
    {
        RaycastHit hitInfo;

        bool hit = Physics.Raycast(firepoint.transform.position, firepoint.transform.forward, out hitInfo);

        // POUR LES SHOOTABLES

        if(hit && hitInfo.collider.tag == "shootable")
        {
            Rigidbody rb = hitInfo.transform.gameObject.GetComponent<Rigidbody>();
            rb.AddForceAtPosition(firepoint.transform.forward * 10, hitInfo.point, ForceMode.Impulse);
            
        }

        // POUR LES ENEMY

        if(hit && hitInfo.transform.gameObject.tag == "Enemy")
        {
            EnemyHealth eh = hitInfo.transform.gameObject.GetComponent<EnemyHealth>();
            eh.TakeDamage(pistolDamage, hitInfo.collider.gameObject);
            
        }
    }
  }
}
