using UnityEngine;

public class PokeBullet : MonoBehaviour
{
    public GameObject ToDes;
    public float BulletSpd;
    private Rigidbody2D rb;
    public float DestroyTimer = 5.0f;

    // Optional initial direction provided by the shooter.
    private Vector2? initialDirection;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        Vector2 direction = initialDirection ?? (Vector2)transform.right;
        rb.linearVelocity = direction.normalized * BulletSpd;

        DestroyBullet();
    }

    public void Initialize(Vector2 direction)
    {
        initialDirection = direction;
    }

    void Update()
    {
    }

    void DestroyBullet()
    {
        Destroy(ToDes, DestroyTimer);
    }

    protected virtual void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("MainCamera"))
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
    }
}
