using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
   
    [SerializeField] List<Transform> spawnPositions;

    [SerializeField] GameObject player;

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
            GameObject go = Instantiate(enemyPrefab,spawnPositions[indexSpawn].position,spawnPositions[0].rotation);

            go.GetComponent<EnemyAI>().player = player;
            //delay
            yield return new  WaitForSeconds (timeBetweenSpawn);
        }

    }
}
