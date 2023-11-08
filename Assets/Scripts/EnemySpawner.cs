using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemyPrefab;
    public float spawnInterval = 2.0f;
    public float destroyTime = 16.0f;

    private void Start()
    {
        
        StartCoroutine(SpawnEnemysCoroutine());

    }

    private IEnumerator SpawnEnemysCoroutine()
    {
        while (true)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(spawnInterval);
            
        }
    }

    private void SpawnEnemy()
    {
            GameObject newEnemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            //destruye el nuevo enemigo despues de un tiempo específico
            Destroy(newEnemy, destroyTime);
    }
    
}


