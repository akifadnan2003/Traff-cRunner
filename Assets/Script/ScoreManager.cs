using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score = 0; // Başlangıç skoru
    public Text scoreText; // Skoru gösterecek UI Text elemanı
    public float scoreIncreaseInterval = 1f; // Skorun artma sıklığı (saniye)
    public int scorePerSecond = 1; // Her saniyede artacak puan

    void Start()
    {
        UpdateScore(); // Başlangıçta skoru güncelle
        InvokeRepeating("IncreaseScoreOverTime", scoreIncreaseInterval, scoreIncreaseInterval); // Sürekli skor artır
    }

    void IncreaseScoreOverTime()
    {
        score += scorePerSecond; // Skoru belirlenen miktarda arttır
        UpdateScore(); // UI'yi güncelle
    }

    public void AddScore(int amount)
    {
        score += amount; // Manuel olarak skor eklemek için kullanılabilir
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "Score: " + score; // Skoru UI'ye yazdır
    }
}
