/* 
using UnityEngine;

public class GameMusicController : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Play(); // Start playing music when the game starts
    }

    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ResumeGame();
        }
    }

   

    void ResumeGame()
    {
        Time.timeScale = 1;
        audioSource.Play(); // Resume the music when the game continues
    }
}
*/

using UnityEngine;

public class GameMusicController : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip coinSound; // Coin toplama sesi
    public AudioClip collisionSound; // Çarpışma sesi

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Play(); // Start playing music when the game starts
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ResumeGame();
        }
    }

    void PauseGame()
    {
        Time.timeScale = 0;
        audioSource.Stop(); // Stop the music when the game is paused
    }

    void ResumeGame()
    {
        Time.timeScale = 1;
        audioSource.Play(); // Resume the music when the game continues
    }

    // Coin toplama sesi çal
    public void PlayCoinSound()
    {
        if (coinSound != null)
        {
            audioSource.PlayOneShot(coinSound);
        }
    }

    // Çarpışma sesi çal
    public void PlayCollisionSound()
    {
        if (collisionSound != null)
        {
            audioSource.PlayOneShot(collisionSound);
        }
    }
}
