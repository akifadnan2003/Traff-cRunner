using UnityEngine;
using UnityEngine.UI;


public class BonusManager : MonoBehaviour
{
    public GameObject[] bonusPrefabs; // Bonus prefab'larını buraya ekle
    public Transform[] spawnPoints; // Bonusların doğacağı noktalar
    public float spawnInterval = 5f; // Bonusların doğma süresi
    public int maxBonuses = 3; // Aynı anda sahnede bulunabilecek maksimum bonus sayısı

    public Text scoreText;           // Skoru gösterecek Text UI öğesi
    private int currentScore = 0;    // Skorun değeri
    
    
    private int currentBonusCount = 0;

    public enum BonusType
    {
    SpeedUp,
    SlowDown,
    ExtraPoints
    }

    void Start()
    {
        UpdateScoreUI(); // Oyuna başlarken skor UI'ını güncelle
        // Bonusları belirli aralıklarla oluştur
        InvokeRepeating("SpawnBonus", spawnInterval, spawnInterval);
    }

    void SpawnBonus()
    {
        if (currentBonusCount >= maxBonuses)
            return; // Maksimum bonus sayısına ulaşıldıysa yeni bonus oluşturma

        // Rastgele bir bonus prefab'ı ve spawn noktası seç
        int randomBonusIndex = Random.Range(0, bonusPrefabs.Length);
        int randomSpawnIndex = Random.Range(0, spawnPoints.Length);

        // Bonusu oluştur
        Instantiate(bonusPrefabs[randomBonusIndex], spawnPoints[randomSpawnIndex].position, Quaternion.identity);

        // Aktif bonus sayısını artır
        currentBonusCount++;
    }

    public void OnBonusCollected(BonusType bonusType, PlayerController player)
    {
        // Bonus türüne göre etkiler
        switch (bonusType)
        {
            case BonusType.SpeedUp:
                StartCoroutine(ApplySpeedBoost(player, 10f, 5f)); // Hız artırma: 2 birim, 5 saniye
                break;

            case BonusType.SlowDown:
                StartCoroutine(ApplySlowDown(player, 3f, 5f)); // Hız düşüşü: 2 birim, 5 saniye
                break;

            case BonusType.ExtraPoints:
                AddScore(10); // 10 puan ekle
                Debug.Log("Ekstra Puan Eklendi!");
                break;
        }

        // Bonus toplandığında aktif bonus sayısını azalt
        currentBonusCount--;
    }


    private void AddScore(int points)
    {
     // Mevcut skoru UI Text'ten al ve ekleme yap
        if (int.TryParse(scoreText.text.Replace("Score: ", ""), out int currentDisplayedScore))
         {
            currentDisplayedScore += points;
            scoreText.text = "Score: " + currentDisplayedScore;
         }
    }


    private void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + currentScore;
        }
    }



    private System.Collections.IEnumerator ApplySpeedBoost(PlayerController player, float amount, float duration)
    {
        Debug.Log("Hız Artırıldı!");
        player.speed += amount; // Hızı artır
        yield return new WaitForSeconds(duration); // Belirtilen süre kadar bekle
        player.speed -= amount; // Hızı normale döndür
    }

    private System.Collections.IEnumerator ApplySlowDown(PlayerController player, float amount, float duration)
    {
        Debug.Log("Hız Azaltıldı!");
        player.speed = Mathf.Max(0, player.speed - amount); // Hızı azalt, negatif olmasını engelle
        yield return new WaitForSeconds(duration); // Belirtilen süre kadar bekle
        player.speed += amount; // Hızı normale döndür
    }
}
