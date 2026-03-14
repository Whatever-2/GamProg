using UnityEngine;

public class FireBullet : PokeBullet
{
    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("GrassEnemy"))
        {
            Destroy(collision.gameObject);
        }
    }
}
