using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MansikKuorrute : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject);

        }

    }
}
