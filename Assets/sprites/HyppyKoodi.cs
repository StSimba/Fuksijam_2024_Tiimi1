using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float jumpForce = 10f;
    public float jumpCooldown = 0.5f;
    public Transform groundCheck;
    public LayerMask groundLayer;
    public GameObject platformPrefab;
    public float platformSpawnRate = 1f;
    public float platformSpawnDistance = 5f;

    private Rigidbody2D rb;
    private bool isGrounded = false;
    private float jumpCooldownTimer = 0f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Check if the character is grounded
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);

        // If character is grounded and jump cooldown is over, jump
        if (isGrounded && jumpCooldownTimer <= 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            jumpCooldownTimer = jumpCooldown;
        }

        // Update jump cooldown timer
        jumpCooldownTimer -= Time.deltaTime;

        // Spawn platforms
        if (Time.time % platformSpawnRate == 0)
        {
            SpawnPlatform();
        }
    }

    private void SpawnPlatform()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-platformSpawnDistance, platformSpawnDistance), transform.position.y + 10f, 0f);
        Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
    }
}
