using UnityEngine;

public class GrassBullet : PokeBullet
{
    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("WaterEnemy"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject); // Destroy the bullet after hitting the enemy
        }
    }
}
