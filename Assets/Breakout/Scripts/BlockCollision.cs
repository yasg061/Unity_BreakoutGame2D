using UnityEngine;

public class BlockCollision : MonoBehaviour
{
    [Header("PowerUp")]
    [SerializeField] private GameObject powerupPrefab;
    [SerializeField] private float powerupSpawnChance = 0.8f; 

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
            Debug.Log("Random value power up: " + randomValue);

            if(randomValue < powerupSpawnChance)
            {
                Instantiate(powerupPrefab, transform.position, Quaternion.identity); 
                Debug.Log("Power up generated!");
            }
        }
    }
}