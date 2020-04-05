using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerControl : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] enemies;
    int randomSpawnPoint, randomEnemy;

    private void Start()
    {
        InvokeRepeating("SpawnEnemies", 1f, 1f);
    }

    void SpawnEnemies()
    {
        randomSpawnPoint = Random.Range(0, spawnPoints.Length);
        randomEnemy = Random.Range(0, enemies.Length);
        Instantiate(enemies[randomEnemy], spawnPoints[randomSpawnPoint].position, Quaternion.identity);
    }
}