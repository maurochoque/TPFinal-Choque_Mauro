using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemyPrefab;
    public float spawnInterval = 2.0f;
    public float destroyTime = 16.0f;
    //public int maxEnemies = 10;

    //private int currentEnemies = 0;


    private void Start()
    {
        //InvokeRepeating("SpawnEnemy", 0f, spawnInterval);
        StartCoroutine(SpawnEnemysCoroutine());

    }

    private IEnumerator SpawnEnemysCoroutine()
    {
        while (true/*currentEnemies < maxEnemies*/)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(spawnInterval);
            
            
        }
    }

    private void SpawnEnemy()
    {
        //if (currentEnemies < maxEnemies)
        //{
            GameObject newEnemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            //currentEnemies++;

            /*Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            currentEnemies++;*/
            //destruye el nuevo enemigo despues de un tiempo específico
            Destroy(newEnemy, destroyTime);



        //}
        
    }
    
}


