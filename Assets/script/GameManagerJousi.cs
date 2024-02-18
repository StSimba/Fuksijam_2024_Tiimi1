using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerJousi : MonoBehaviour
{
    public GameObject JousiPrefab;

    public int JousiCount = 40;


    void Start()
    {
        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < JousiCount; i++)
        {
            spawnPosition.y += Random.Range(.5f, 50f);
            spawnPosition.x = Random.Range(-5f, 5f);
            Instantiate(JousiPrefab, spawnPosition, Quaternion.identity);
        }
    }
}