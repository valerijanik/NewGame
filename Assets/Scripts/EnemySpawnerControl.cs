using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerControl : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] enemies;
    int randomSpawnPoint, randomEnemy;

    private float speedFactor; // start with regular speed
    public float spawnInterval = 2.0f; // default spawn rate = one every 2 seconds
    private float spawnTimeLeft;

    private void Update()
    {
        speedFactor += Time.deltaTime * 0.1f;

        spawnTimeLeft -= Time.deltaTime * speedFactor; // higher speed factor = faster spawns;
        while (spawnTimeLeft < 0.0f)
        {
            spawnTimeLeft += spawnInterval;
            SpawnEnemies();
        }
    }

    void SpawnEnemies()
    {
        randomSpawnPoint = Random.Range(0, spawnPoints.Length);
        randomEnemy = Random.Range(0, enemies.Length);
        Instantiate(enemies[randomEnemy], spawnPoints[randomSpawnPoint].position, Quaternion.identity);
    }
}