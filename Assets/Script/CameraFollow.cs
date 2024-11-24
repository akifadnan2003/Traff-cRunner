using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Takip edilecek oyuncu
    public float smoothSpeed = 0.125f; // Kameranın geçiş hızı
    public Vector2 offset; // Kameranın oyuncuya göre pozisyon farkı
    public Vector2 followLimits; // Kameranın ileri veya geri hareket sınırları (x: yatay, y: dikey)

    void LateUpdate()
    {
        if (player == null) return;

        // Kameranın yeni pozisyonunu hesapla
        Vector3 desiredPosition = new Vector3(
            Mathf.Clamp(player.position.x + offset.x, -followLimits.x, followLimits.x),
            Mathf.Clamp(player.position.y + offset.y, -followLimits.y, followLimits.y),
            transform.position.z);

        // Kamerayı yumuşak bir şekilde hareket ettir
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
    }


    
}
