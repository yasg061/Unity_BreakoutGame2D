using UnityEngine;

public class PowerUp : MonoBehaviour
{
    [Header("PowerUp Settings")]
    [SerializeField] private float fallSpeed = 2.0f;
    [SerializeField] private float growthAmount = 1.5f;

    void Update()
    {
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime); 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Paddle"))
        {
            Debug.Log("Power up collected! Paddle grows!");
            Vector3 newScale = new Vector3(collision.transform.localScale.x * growthAmount, 
                                            collision.transform.localScale.y, 
                                            collision.transform.localScale.z);
            collision.transform.localScale = newScale;
            Destroy(gameObject); 
        }
    }

}
