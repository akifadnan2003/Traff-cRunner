
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour
{
    public GameObject pauseMenu; 
    private bool isPaused = false; 

    private void Start()
    {
        if (pauseMenu != null)
        {
            pauseMenu.SetActive(false); 
        }
        else
        {
            Debug.LogError("PausePanel referansı atanmadı!"); 
        }
    }

    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Resume();
        }
    }


    public void PauseGame()
    {
        isPaused = true; 
        Time.timeScale = 0; 
        if (pauseMenu != null)
        {
            pauseMenu.SetActive(true); 
        }
        else
        {
            Debug.LogError("PausePanel referansı atanmadı!"); 
        }
    }


    public void ReturnToMainMenu()
    {
        Time.timeScale = 1; 
        SceneManager.LoadScene("Main"); 
    }
       public void Restart()

    {

        SceneManager.LoadScene("Game");

    }
    
    public void Resume()
    {
        isPaused = false; 
        Time.timeScale = 1; 
        if (pauseMenu != null)
        {
            pauseMenu.SetActive(false); 
        }
        else
        {
            Debug.LogError("PausePanel referansı atanmadı!"); 
        }
    }
}
