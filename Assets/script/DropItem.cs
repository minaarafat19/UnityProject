using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropItem : MonoBehaviour
{
    [SerializeField]
    GameObject trousseDeSoin;
   
    [SerializeField]

    [Range(0,100)]
    float dropRate=30;

    private void OnDestroy()
    {
        float randomf = Random.Range(0,100);

        if(randomf <= dropRate)
        {
            Instantiate(trousseDeSoin,transform.position,transform.rotation);
        }
        
    }
}
