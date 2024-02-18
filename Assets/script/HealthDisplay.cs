using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    public int health;
    public int maxHealth;

    public Sprite emptyHeart;
    public Sprite fullHeart;
    public Image[] hearts;
    public List<Image> heartsList = new List<Image>();

    public PlayerHealth playerHealth;
    

    // Start is called before the first frame update
    void Start()
    {
        if (fullHeart == null)
            Debug.Log("ERROR");




    }

    void Update()
    {
        health = playerHealth.currentHealth;
        maxHealth = playerHealth.maxHealth;


        for (int i = 0; i < heartsList.Count; i++)
        {
            Debug.Log(i);

            if (i < health)
            {
                heartsList[i].sprite = fullHeart;
            }
            else
            {
                heartsList[i].sprite = emptyHeart;
            }

            if (i < maxHealth)
            {
                heartsList[i].enabled = true;
            }
            else
            {
                heartsList[i].enabled = false;
            }

        }

    }
}
