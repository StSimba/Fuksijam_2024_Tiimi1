using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class GameOver : MonoBehaviour

{
    public GameObject Win;
    public GameObject menu;

    private void Start()
    {
        //die_txt.SetActive(false);
        menu.SetActive(false);
        Win.SetActive(false);
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Die")
        {
            EndGame();
            menu.SetActive(true);
            
        }

        if (collision.gameObject.tag == "Finish")
        {
            EndGame();
            menu.SetActive(true);
            Win.SetActive(true);

        }
    }

    public void OnButtonClick()
    {
        Application.Quit();
    }

    

    void EndGame()
    {
        Debug.Log("Game Over!");
       // CackeUpgrade.UpdateScore(CackeUpgrade.Score);

        Time.timeScale = 0f;
    }
}
