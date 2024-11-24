using UnityEngine;

public class PowerUp : MonoBehaviour
{
   
    public BonusManager.BonusType bonusType; 

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Güçlendirme alındı!");
            PlayerController player = other.GetComponent<PlayerController>();
            if (player != null)
            { BonusManager manager = FindObjectOfType<BonusManager>();

                if (manager != null)
                
                {
                    manager.OnBonusCollected(bonusType, player);
                }
            }
            Destroy(gameObject); // Güçlendirme aldıktan sonra yok edin
        }
    }
}
