using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    public float speed = 8f;
    public float jumpForce = 12f;
    public Transform groundCheck;
    public float groundCheckDistance = 0.12f;
    public Vector2 groundCheckOffset = new Vector2(0f, -0.5f);
    public LayerMask groundLayer;

    public CollectibleManager cm; //For collectible

    private Rigidbody2D rb;
    private float horizInput;
    private bool isGrounded;
    private SpriteRenderer spriteRenderer;
    private Animator animator;

    AudioManager audioManager;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        horizInput = Input.GetAxisRaw("Horizontal");

        Vector2 rayOrigin = groundCheck != null ? (Vector2)groundCheck.position : (Vector2)transform.position + groundCheckOffset;
        RaycastHit2D hit = Physics2D.Raycast(rayOrigin, Vector2.down, groundCheckDistance, groundLayer);
        isGrounded = hit.collider != null;

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }

        if (spriteRenderer != null)
        {
            if (horizInput > 0.1f) spriteRenderer.flipX = false;
            else if (horizInput < -0.1f) spriteRenderer.flipX = true;
        }

        // Updated animator parameters
        if (animator != null)
        {
            animator.SetFloat("moveInput", Mathf.Abs(horizInput));
            animator.SetBool("isGrounded", isGrounded);
        }
    }

    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(horizInput * speed, rb.linearVelocity.y);
    }


    void OnDrawGizmosSelected()
    {
        if (groundCheck != null)
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawLine(groundCheck.position, groundCheck.position + Vector3.down * groundCheckDistance);
        }
        else
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawLine(transform.position + (Vector3)groundCheckOffset, transform.position + (Vector3)groundCheckOffset + Vector3.down * groundCheckDistance);
        }
    }


    //Collectible
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            cm.trashCount ++;
        }
    }
}