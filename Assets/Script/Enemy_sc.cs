using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3f; 

    void Update()
    {
        // Move the enemy downward continuously (along the y-axis)
        transform.Translate(Vector2.down * speed * Time.deltaTime);

        // Check if the enemy has moved off-screen (bottom)
        if (transform.position.y < -10f) // If off the bottom of the screen
        {
            // Reset to the top with a random x position
            transform.position = new Vector2(Random.Range(-4f, 4f), 10f); 
        }
    }

    void OnDestroy()
    {
        EnemyManager enemyManager = FindObjectOfType<EnemyManager>();
        if (enemyManager != null)
        {
            enemyManager.OnEnemyDestroyed();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Enemy collided with the player!");
            // Additional collision logic can be added here
        }
    }
}
