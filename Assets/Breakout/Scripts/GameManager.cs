using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Paddle Settings")]
    [SerializeField] private int score = 0;
    [SerializeField] private int pointsPerBlock = 0;

    public void AddScore()
        {
        score = score + pointsPerBlock; //score += pointsPerBlock;
        Debug.Log("Puntaje: " + score); //Imprimir puntaje actual
    }
}