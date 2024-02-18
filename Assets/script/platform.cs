using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float jumpForce = 10f;
    public float springforce = 30f;
    //public float jump;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            if (collision.gameObject.CompareTag("Ground"))
            {
                Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
                if (rb != null)
                {
                    Vector2 velocity = rb.velocity;
                    velocity.y = jumpForce;
                    rb.velocity = velocity;
                }
            }
        }
    //    if (collision.relativeVelocity.y <= 0f)
    //    {
    //        if (collision.gameObject.CompareTag("Jousi"))
    //        {
    //            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
    //            if (rb != null)
    //            {
    //                Vector2 velocity = rb.velocity;
    //                velocity.y = springforce;
    //                rb.velocity = velocity;
    //            }
    //        }
    //    }

    }
   

    
}