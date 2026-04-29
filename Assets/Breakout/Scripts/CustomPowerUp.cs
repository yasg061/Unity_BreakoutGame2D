using UnityEngine;

public class CustomPower : MonoBehaviour
{
    [SerializeField] private float fallSpeed = 2f;
    [SerializeField] private GameObject ballPrefab;

    void Update()
    {
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Paddle"))
        {
            Debug.Log("Duplicate Ball Power!");

            GameObject currentBall = GameObject.FindGameObjectWithTag("Ball");

            if (currentBall != null)
            {
                GameObject newBall = Instantiate(
                    ballPrefab,
                    currentBall.transform.position,
                    Quaternion.identity
                );

                Rigidbody2D rb = newBall.GetComponent<Rigidbody2D>();

                Vector2 newDirection = new Vector2(Random.Range(-1f, 1f), 1f).normalized;
                rb.linearVelocity = newDirection * 5f;
            }

            Destroy(gameObject);
        }
    }
}