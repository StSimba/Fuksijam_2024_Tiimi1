using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;



public class PlayerHealth : MonoBehaviour
  

{
    public int currentHealth;
    public int maxHealth = 3;
    
    public GameObject menu;
    // Start is called before the first frame update
    void Start()
    {
            currentHealth = maxHealth; 
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("KakkuLapio"))
        {
            Debug.Log("yvjhvyjjyvjygj");
            TakeDamage(1);
        }

    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            
            
            menu.SetActive(true);
            Time.timeScale = 0;
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    
}
