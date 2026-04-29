using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Vector2 initialDirection = new Vector2(0, 1);

    private Vector2 currentDirection;

    void Start()
    {
        currentDirection = initialDirection.normalized;
        rb.linearVelocity = currentDirection * speed;   
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 normal = collision.contacts[0].normal;
        currentDirection = Vector2.Reflect(currentDirection, normal).normalized;
        rb.linearVelocity = currentDirection * speed;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Floor"))
        {
            Debug.Log("Ball lost! GAME OVER!");
        }
    }

}
