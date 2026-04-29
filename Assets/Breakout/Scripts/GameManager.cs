using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Scores")]
    [SerializeField] private int score = 0;
    [SerializeField] private int pointsPerBlock = 10;

    private int blocksRemaining;

    private void Start()
    {
        blocksRemaining = GameObject.FindGameObjectsWithTag("Brick").Length;
        Debug.Log("Initial blocks: " + blocksRemaining);
    }

    public void AddScore()
    {
        score = score + pointsPerBlock; 
        Debug.Log("Score: " + score);
    }

    public void BlockDestroyed()
    {
        blocksRemaining = blocksRemaining - 1; 
        Debug.Log("Blocks remaining: " + blocksRemaining);

        if(blocksRemaining <= 0)
        {
            Debug.Log("¡You Win! All blocks destroyed!");
        }
    }
}