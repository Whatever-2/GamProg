using UnityEngine;

public class FirePlayer : Player
{   

    
    public PokeBullet bulletPrefab;

    protected override void Attack()
    {
           if (Input1.WasPressedThisFrame())
        {
            PokeBullet bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            bullet.Initialize(LastDirection);
            bullet.transform.right = LastDirection; // Rotate the bullet to face the direction it's moving
        }  
            
    }

    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D(collision); // Call the base method to handle Pokeball collisions
        if (collision.gameObject.CompareTag("WaterEnemy"))
        {
            Destroy(gameObject);
        }
    }


}
