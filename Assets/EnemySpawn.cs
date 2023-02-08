using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
   
    [SerializeField] List<Transform> spawnPositions;

    [SerializeField] float timeBetweenSpawn;


     //Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }
    
    IEnumerator SpawnEnemy()
    {
       
        while(Player.instance != null )
        {
            int indexSpawn = Random.Range(0,spawnPositions.Count);
            //spawn enemy
            Instantiate(enemyPrefab,spawnPositions[indexSpawn].position,spawnPositions[0].rotation);
            //delay
            yield return new  WaitForSeconds (timeBetweenSpawn);
        }

    }
}
