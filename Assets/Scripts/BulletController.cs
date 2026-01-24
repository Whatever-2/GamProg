using UnityEngine;

public class BulletController : MonoBehaviour
{
    public GameObject ToDes;
    public float BulletSpd;
    private Rigidbody2D rb;
    public float DestroyTimer = 5.0f;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = transform.right * BulletSpd;

        
        DestroyBullet();
    }


    void Update()
    {
        
    }

        void DestroyBullet()
    {
        Destroy(ToDes,DestroyTimer);
    }

     void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
        }
    }

    void OnTriggerExit2D (Collider2D collision)
    {
        
    }
    void OnTriggerStay2D (Collider2D collision)
    {
        
    }

}
