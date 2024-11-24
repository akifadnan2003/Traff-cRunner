using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs; // Store different enemy prefabs here
    public Transform[] spawnPoints; // Spawn points
    public float spawnInterval = 0.5f; // Interval between spawns

    private bool spawningEnemies = true; // Flag to control spawning
    private int currentEnemyCount = 0; // Current number of active enemies

    void Start()
    {
        // Start spawning enemies at regular intervals
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        while (spawningEnemies)
        {
            if (currentEnemyCount >= 10) // Ensure max enemies limit
            {
                yield return new WaitForSeconds(spawnInterval);
                continue;
            }

            // Randomly select an enemy prefab
            int randomEnemyIndex = Random.Range(0, enemyPrefabs.Length);
            int randomSpawnIndex = Random.Range(0, spawnPoints.Length);

            // Generate a random offset to avoid enemies spawning at the exact same position
            float randomOffsetX = Random.Range(-0.5f, 0.5f); // Adjust the range as needed
            float randomOffsetY = Random.Range(-0.5f, 0.5f); // Adjust the range as needed

            // Calculate the new spawn position with the random offset
            Vector2 spawnPosition = new Vector2(
                spawnPoints[randomSpawnIndex].position.x + randomOffsetX,
                spawnPoints[randomSpawnIndex].position.y + randomOffsetY
            );

            // Spawn the enemy at the calculated spawn position
            Instantiate(enemyPrefabs[randomEnemyIndex], spawnPosition, Quaternion.identity);

            // Increase the active enemy count
            currentEnemyCount++;

            // Wait for the next spawn interval
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    public void StopSpawning()
    {
        spawningEnemies = false;
    }

    public void OnEnemyDestroyed()
    {
        if (currentEnemyCount > 0)
        {
            currentEnemyCount--;
        }
    }
}
