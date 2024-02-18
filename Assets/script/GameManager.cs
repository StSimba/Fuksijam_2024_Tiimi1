using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject platformPrefab;

    public int platformCount = 250;


    void Start()
    {
        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < platformCount; i++)
        {
            spawnPosition.y += Random.Range(.5f, 3f);
            spawnPosition.x = Random.Range(-6.5f, 6.5f);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
    }
}