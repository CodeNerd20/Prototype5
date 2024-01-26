using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnPrefab;

    public void SpawnBall()
    {
        Instantiate(spawnPrefab, transform.position, transform.rotation);
    }

    public void SpawnBall(int numberOfBallsToSpawn)
    {
        for(int i = 0; i< numberOfBallsToSpawn; i++)
        {
            Instantiate(spawnPrefab, transform.position, transform.rotation);
        }
    }
}
