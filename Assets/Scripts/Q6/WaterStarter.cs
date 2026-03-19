using UnityEngine;

public class WaterStarter : Player
{
    public PokeBullet bulletPrefab;

    protected override void Attack()
    {
        float HomingRange = 2f; // range on when the bullet will start targeting enemies


           if (Input1.WasPressedThisFrame())
        {
            PokeBullet bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            bullet.Initialize(LastDirection);
            bullet.transform.right = LastDirection; // Rotate the bullet to face the direction it's moving
            //set the range of collider base on the homing range
            CircleCollider2D collider = bullet.GetComponent<CircleCollider2D>();
            if (collider != null)
            {
                collider.radius = HomingRange;
            }
        }  
            
    }

    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D(collision);

        if (collision.gameObject.CompareTag("GrassEnemy"))
        {
            Destroy(gameObject);
        }
    }

}
