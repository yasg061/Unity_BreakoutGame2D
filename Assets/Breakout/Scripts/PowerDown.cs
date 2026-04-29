using UnityEngine;

public class PowerDown : MonoBehaviour
{
    [Header("PowerDown Settings")]
    [SerializeField] private float fallSpeed = 2.0f;
    [SerializeField] private float shrinkAmount = 0.7f; 

    void Update()
    {
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Paddle"))
        {
            Debug.Log("Power DOWN collected! Paddle shrinks!");

            Vector3 newScale = new Vector3(
                collision.transform.localScale.x * shrinkAmount,
                collision.transform.localScale.y,
                collision.transform.localScale.z
            );

            collision.transform.localScale = newScale;

            Destroy(gameObject);
        }
    }
}