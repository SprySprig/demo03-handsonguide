using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    [HideInInspector]
    public bool isFacingRight = true;

    [HideInInspector]
    public bool isJumping = false;

    [HideInInspector]
    public bool isGrounded = false;

    public float jumpForce = 650.0f;
    public float maxSpeed = 7.0f;

    public Transform groundCheck;
    public LayerMask groundLayers;

    private float groundCheckRadius = 0.2f;

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (isGrounded)
            {
                Rigidbody2D rigidBody2D = this.GetComponent<Rigidbody2D>();
				rigidBody2D.velocity = new Vector2(rigidBody2D.velocity.x, 0);
				rigidBody2D.AddForce(new Vector2(0, jumpForce));
            }
        }
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayers);

        float move = Input.GetAxis("Horizontal");
        Rigidbody2D rigidBody2D = this.GetComponent<Rigidbody2D>();
        rigidBody2D.velocity = new Vector2(move * maxSpeed, rigidBody2D.velocity.y);

        if ((move > 0.0f && !isFacingRight) || (move < 0.0f && isFacingRight))
        {
            Flip();
        }
    }

    void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 playerScale = transform.localScale;
        playerScale.x = playerScale.x * -1;
        transform.localScale = playerScale;
    }
}
