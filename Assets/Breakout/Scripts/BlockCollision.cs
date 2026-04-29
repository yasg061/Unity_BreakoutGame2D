using UnityEngine;

public class BlockCollision : MonoBehaviour
{
   
    private GameManager gameManager;
    private void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>(); 
    }    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Debug.Log("Block hit!");
            gameManager.AddScore();
            Destroy(gameObject);
        }
    }

}
