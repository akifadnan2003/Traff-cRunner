using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public int health = 100;
    public int points = 0;

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        transform.Translate(movement * speed * Time.deltaTime);

        /*if (transform.position.y >= 7.3f)
        {
            transform.position = new Vector3(transform.position.x, 7.3f, 0);

        }
        else if (transform.position.y <= -5.3f)
        {
            transform.position = new Vector3(transform.position.x, -5.3f, 0);
        }
*/
        if (transform.position.x >= 9.55f)
        {
            transform.position = new Vector3(-9.55f, transform.position.y, 0);
        }
        else if (transform.position.x <= -11.75f)
        {
            transform.position = new Vector3(9.55f, transform.position.y, 0);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Araba bir engele çarptı!");
            health -= 10;
            if (health <= 0)
            {
                EndGame();
            }
        }
        else if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Bir düşmanla çarpıştınız!");
            health -= 20;
            if (health <= 0)
            {
                EndGame();
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PowerUp"))
        {
            Debug.Log("Güçlendirme aldınız!");
            points += 10;
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Checkpoint"))
        {
            Debug.Log("Kontrol noktasına ulaşıldı!");
            // Kontrol noktası mantığını buraya ekleyin
        }
    }

    void EndGame()
    {
        Time.timeScale = 0;
        Debug.Log("Oyun Bitti! Oynadığınız için teşekkürler.");
    }
}

