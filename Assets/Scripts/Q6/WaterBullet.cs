using UnityEngine;

public class WaterBullet : PokeBullet
{
    protected Transform target;
    protected virtual string EnemyTag => "FireEnemy";
    public float destroyRange = 2f;

    void Start()
    {
        base.Start(); // Call base Start to set initial velocity

        // Find the closest enemy
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(EnemyTag);
        float minDist = Mathf.Infinity;
        foreach (GameObject enemy in enemies)
        {
            float dist = Vector2.Distance(transform.position, enemy.transform.position);
            if (dist < minDist)
            {
                minDist = dist;
                target = enemy.transform;
            }
        }
    }

    void Update()
    {
        if (target != null)
        {
            Vector2 direction = (target.position - transform.position).normalized;
            rb.linearVelocity = direction * BulletSpd;
        }
    }

    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("FireEnemy"))
        {
            float dist = Vector2.Distance(transform.position, collision.transform.position);
            if (dist <= destroyRange)
            {
                Destroy(collision.gameObject);
                Destroy(gameObject); // Destroy the bullet after hitting the enemy
            }
        }
    }
}
