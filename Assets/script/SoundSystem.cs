using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSystem : MonoBehaviour
{
    [SerializeField] AudioClip Sound;
    [SerializeField] GameObject player;

    private void OnTriggerEnter(Collider other) 
    {
        
        if(other.tag == "Player"){
            
            AudioSource.PlayClipAtPoint(Sound, player.transform.position, 1f);

        }
    }
}
