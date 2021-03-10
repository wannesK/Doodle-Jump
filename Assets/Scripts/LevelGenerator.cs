using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject platformPrefeb;

    public int numberOfPlatforms;
    public float levelWidth;
    public float minY = .8f;
    public float maxY = 1.3f;

    private void Start()
    {
        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < numberOfPlatforms; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x += Random.Range(-levelWidth, levelWidth);
            Instantiate(platformPrefeb, spawnPosition, Quaternion.identity);
        }
    }

}
