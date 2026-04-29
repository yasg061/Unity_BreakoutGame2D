using UnityEngine;

public class PaddleMovement : MonoBehaviour
{

    [Header("Paddle Settings")]
    [SerializeField] private float Speed = 10f;
    [SerializeField] private Rigidbody2D rb;


    [Header("Boundary Settings")]
    [SerializeField] private float minX = -10f;
    [SerializeField] private float maxX = 10f;

    private float input;

    private void Update()
    {
        input = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        float velocityX = input * Speed;
        rb.linearVelocity = new Vector2(velocityX, 0);

        Vector2 pos = rb.position;
        pos.x = Mathf.Clamp(pos.x, minX, maxX);
        rb.position = pos;
    }

}
