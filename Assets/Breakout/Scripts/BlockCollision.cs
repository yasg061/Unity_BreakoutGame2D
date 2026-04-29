using UnityEngine;

public class BlockCollision : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private GameObject powerUpPrefab;
    [SerializeField] private GameObject powerDownPrefab;
    [SerializeField] private GameObject customPowerPrefab;

    private GameManager gameManager;

    private void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>(); 
                                                            
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Ball"))
        {
            Debug.Log("Ball collided with block!");
            gameManager.AddScore(); 
            gameManager.BlockDestroyed(); 
            Destroy(gameObject); 

            float randomValue = Random.value; 
            Debug.Log("Random value: " + randomValue);

            if (randomValue < 0.3f)
            {
                Instantiate(powerUpPrefab, transform.position, Quaternion.identity); 
                Debug.Log("Spawn: Grow PowerUp");
            }
            else if (randomValue < 0.6f)
            {
                Instantiate(powerDownPrefab, transform.position, Quaternion.identity); 
                Debug.Log("Spawn: Shrink PowerUp");
            }
            else
            {
                Instantiate(customPowerPrefab, transform.position, Quaternion.identity);
                Debug.Log("Spawn: Custom PowerUp");
            }
        }
    }
}