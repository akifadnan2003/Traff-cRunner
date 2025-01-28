using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public GameObject mainMenuPanel;

    public void StartGame()
    {
        Debug.Log("StartGame çağrıldı!");
        mainMenuPanel.SetActive(false); 
        Time.timeScale = 1; 
        Debug.Log("Time.timeScale: " + Time.timeScale); 

        SceneManager.LoadScene("Game"); 
    }

    private void Start()
    {
        Time.timeScale = 0; 
        Debug.Log("Oyun durduruldu. Time.timeScale: " + Time.timeScale); 
        if (mainMenuPanel != null)
        {
            mainMenuPanel.SetActive(true); 
        }
        else
        {
            Debug.LogError("mainMenuPanel referansı atanmadı!");
        }
    }

    public void QuitGame()
    {
        Debug.Log("QuitGame çağrıldı. Uygulama kapatılıyor.");
        Application.Quit(); 
    }
}
