using UnityEngine;

public class GrassStarter : Player
{
   public PokeBullet bulletPrefab;

    protected override void Attack()
    {
           if (Input1.WasPressedThisFrame())
        {
            PokeBullet bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
     

        }  
            
    }

    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D(collision);

        if (collision.gameObject.CompareTag("FireEnemy"))
        {
            Destroy(gameObject);
        }
    }
}
