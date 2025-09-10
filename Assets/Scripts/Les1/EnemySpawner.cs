using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private List<GameObject> enemies = new List<GameObject>();
    [SerializeField] private int waveSize = 100;
    [SerializeField] private float spawnInterval = 1f;
    [SerializeField] private int spawnPerSecond = 3;

    private Coroutine spawnRoutine;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            SpawnWave(waveSize);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (spawnRoutine == null)
            {
                spawnRoutine = StartCoroutine(SpawnContinuously());
            }
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            if (spawnRoutine != null)
            {
                StopCoroutine(spawnRoutine);
                spawnRoutine = null;
            }
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            ClearEnemies();
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            StartCoroutine(RemoveEnemiesOneByOne());
        }
    }

    private void SpawnWave(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            SpawnEnemy();
        }
    }

    private IEnumerator SpawnContinuously()
    {
        while (true)
        {
            for (int i = 0; i < spawnPerSecond; i++)
            {
                SpawnEnemy();
            }
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    private void SpawnEnemy()
    {
        GameObject enemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        enemies.Add(enemy);
    }

    private void ClearEnemies()
    {
        foreach (GameObject enemy in enemies)
        {
            if (enemy != null)
            {
                Destroy(enemy);
            }
        }
        enemies.Clear();
    }

    private IEnumerator RemoveEnemiesOneByOne()
    {
        while (enemies.Count > 0)
        {
            GameObject enemy = enemies[0];
            enemies.RemoveAt(0);
            Destroy(enemy);
            yield return new WaitForSeconds(0.1f); 
        }
    }
}
