using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    private Rigidbody2D rb;

    private float moveX;
    public float jumpForce = 10f; // Perushyppyvoiman m‰‰r‰

    //private bool isGrounded;
    public float SpringForce = 20f;
    

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveX = Input.GetAxis("Horizontal") * moveSpeed;

        //if (isGrounded = true)
        //{
        //    Jump();
        //}
    }

    private void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = moveX;
        rb.velocity = velocity;
    }

    //public void Jump()
    //{
    //    rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    //}

    //void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Ground"))
    //    {
    //        isGrounded = true;
    //    }
    //}

    //void OnCollisionExit2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Ground"))
    //    {
    //        isGrounded = false;
    //    }
    //}

    public void IncreaseJumpForce(float extraJumpForce)
    {
        jumpForce += extraJumpForce;
    }

  
}