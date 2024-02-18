using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringScript : MonoBehaviour
{
    public float springJumpForce = 20f; // Jousisymbolista saatava lisähyppyvoima

    // Jos pelaaja osuu jousisymboliin, annetaan pelaajalle lisähyppyvoimaa
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerController playerController = other.gameObject.GetComponent<PlayerController>();
            if (playerController != null)
            {
                playerController.IncreaseJumpForce(springJumpForce);
               // playerController.Jump(playerController.jumpForce + springJumpForce);
            }
        }
    }
}