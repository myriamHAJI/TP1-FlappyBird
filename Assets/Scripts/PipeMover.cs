using UnityEngine;

public class PipeMover : MonoBehaviour
{
    public float startSpeed = 2f;
    public float speedIncrease = 0.08f;
    public float maxSpeed = 3.5f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float currentSpeed =
            startSpeed + Time.timeSinceLevelLoad * speedIncrease;

        currentSpeed = Mathf.Min(currentSpeed, maxSpeed);

        rb.linearVelocity = Vector2.left * currentSpeed;

        if (transform.position.x < -2f)
        {
            Destroy(gameObject);
        }
    }
}