using UnityEngine;
using System.Collections.Generic;

public class CackeUpgrade : MonoBehaviour
{
    // Reference to the SpriteRenderer component
    private SpriteRenderer spriteRenderer;

    // List of sprites to cycle through
    public List<Sprite> spriteList = new List<Sprite>();

    // Index to keep track of the current sprite in the list
    private int currentIndex = 0;

    void Start()
    {
        // Get the SpriteRenderer component attached to this GameObject
        spriteRenderer = GetComponent<SpriteRenderer>();

        // Check if spriteRenderer is null (to prevent null reference errors)
        if (spriteRenderer == null)
        {
            Debug.LogError("SpriteRenderer component not found on this GameObject!");
        }

        // Ensure the spriteList is not empty
        if (spriteList.Count == 0)
        {
            Debug.LogError("Sprite list is empty! Please assign sprites.");
        }
    }


    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Upgrade"))
        {
            Debug.Log("Upgraded");
            
            ChangeSpriteToNext();
            
        }

    }
    // Function to change the sprite to the next one in the list
    public void ChangeSpriteToNext()
    {
    

        // Wrap around if we reach the end of the list
        if (currentIndex >= spriteList.Count)
        {
            currentIndex = 0;
        }

        // Change the sprite
        spriteRenderer.sprite = spriteList[currentIndex];
        
        currentIndex++;
    }
}