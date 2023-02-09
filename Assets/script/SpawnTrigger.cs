using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrigger : MonoBehaviour
{
    public GameObject spawner;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            spawner.SetActive(true);
        }

    }  
}