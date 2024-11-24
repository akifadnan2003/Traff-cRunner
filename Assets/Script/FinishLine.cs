using UnityEngine;
using TMPro; // Import TextMeshPro namespace

public class FinishLine : MonoBehaviour
{
    private EnemyManager enemyManager;
    public TextMeshProUGUI gameOverText; // Reference to the TextMeshPro Text component for Game Over message

    void Start()
    {
        enemyManager = FindObjectOfType<EnemyManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player crossed the finish line!");
            enemyManager.StopSpawning(); // Stop spawning enemies
            Time.timeScale = 0; // Pause the game
            ShowGameFinishedMessage("Game Finished! You crossed the finish line.");
        }
    }

    void ShowGameFinishedMessage(string message)
    {
        gameOverText.text = message;
        gameOverText.gameObject.SetActive(true); // Display the Game Finished message
    }
}
