using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemyPrefab;
    public GameObject powerUpPrefab;
    private int waveCounter = 1;
    void Start()
    {
        SpawnEnemyWave(waveCounter);
    }

 

    // Update is called once per frame
    void Update()
    {
        int enemyCount = FindObjectsOfType<Enemy>().Length;
        if(enemyCount == 0)
        {
            waveCounter++;
            SpawnEnemyWave(waveCounter);
        }
    }
    private static Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-9, 9);
        float spawnPosZ = Random.Range(-9, 9);
        Vector3 spawnPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return spawnPos;
    }
    private void SpawnEnemyWave(int enemiesToSpawn)
    {
        for(int i = 0; i < enemiesToSpawn; i++)
        {
            Vector3 spawnPos = GenerateSpawnPosition();
            Instantiate(enemyPrefab, spawnPos, enemyPrefab.transform.rotation);
            Instantiate(powerUpPrefab, GenerateSpawnPosition(), powerUpPrefab.transform.rotation);
        }
    }
}
