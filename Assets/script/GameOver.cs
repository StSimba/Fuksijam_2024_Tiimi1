using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    
    //public GameObject die_txt;
    public GameObject menu;

    private void Start()
    {
        //die_txt.SetActive(false);
        menu.SetActive(false);
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Die")
        {
            EndGame();
            //die_txt.SetActive(true);
            menu.SetActive(true);
        }
    }

    void EndGame()
    {
        Debug.Log("Game Over!");
        Time.timeScale = 0f;
    }
}
