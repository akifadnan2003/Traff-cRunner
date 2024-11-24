using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform playerTransform; // Oyuncunun Transform'u
    private Vector3 lastPosition; // Son pozisyon
    public int scorePerUnit = 1; // Bir birim ilerlemede artacak skor
    private float totalDistance = 0f; // Toplam ilerlenen mesafe

    private ScoreManager scoreManager; // Skor yöneticisi referansı

    void Start()
    {
        if (playerTransform == null)
            playerTransform = transform; // Eğer atanmadıysa oyuncunun kendisini al

        lastPosition = playerTransform.position; // Başlangıç pozisyonunu kaydet
        scoreManager = FindObjectOfType<ScoreManager>(); // ScoreManager'ı bul
    }

    void Update()
    {
        // İlerlenen mesafeyi hesapla
        float distance = Vector3.Distance(playerTransform.position, lastPosition);
        totalDistance += distance;

        // Her bir birim mesafe için skoru arttır
        if (totalDistance >= 1f) // 1 birimden fazla ilerlenmişse
        {
            int scoreToAdd = Mathf.FloorToInt(totalDistance) * scorePerUnit; // Eklenmesi gereken skor
            scoreManager.AddScore(scoreToAdd); // Skor ekle
            totalDistance -= Mathf.Floor(totalDistance); // Fazlalığı kaybetme
        }

        lastPosition = playerTransform.position; // Son pozisyonu güncelle
    }
}
