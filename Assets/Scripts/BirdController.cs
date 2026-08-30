using UnityEngine;
using UnityEngine.InputSystem;

public class BirdController : MonoBehaviour
{
    public float jumpForce = 4.5f;
    public GameManager gameManager;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!gameManager.gameOver &&
            Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            rb.linearVelocity = Vector2.up * jumpForce;
            gameManager.PlayJumpSound();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.EndGame();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Pipe"))
        {
            gameManager.EndGame();
        }
        else if (collision.CompareTag("Score"))
        {
            gameManager.AddScore();
        }
    }
}