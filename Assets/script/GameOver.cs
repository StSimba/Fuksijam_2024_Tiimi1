using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public float lowerLimit = -10f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Die")
        {
            EndGame();
        }
    }

    void EndGame()
    {
        Debug.Log("Game Over!");
        Time.timeScale = 0f;
    }
}
