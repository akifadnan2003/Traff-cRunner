using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void EndGame()
    {
        Time.timeScale = 0;
        Debug.Log("Oyun Bitti! Oynadığınız için teşekkürler.");
        // Oyun bitiş ekranını burada gösterebilirsiniz
    }
}
