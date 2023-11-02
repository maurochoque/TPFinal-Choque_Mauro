using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemyPrefab;
    public float spawnInterval = 2.0f;
    public int maxEnemies = 10;

    private int currentEnemies = 0;


    private void Start()
    {
        InvokeRepeating("SpawnEnemy", 0f, spawnInterval);
    }

    private void SpawnEnemy()
    {
        if (currentEnemies < maxEnemies)
        {
            GameObject newEnemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            currentEnemies++;

            /*Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            currentEnemies++;*/
            // Destruye el nuevo enemigo después de un tiempo específico (por ejemplo, 5 segundos).
            Destroy(newEnemy, 18.0f);

        }
        
    }
    
}


