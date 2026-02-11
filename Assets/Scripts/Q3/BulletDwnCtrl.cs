using UnityEngine;

public class BulletDwnCtrl : MonoBehaviour
{
    public GameObject ToInc;//identify increment obj
    public GameObject ToDec;//identify decrement obj    
    public float BulletSpd;
    private Rigidbody2D rb;
    public float DestroyTimer = 5.0f;
    public 


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = transform.up * BulletSpd;
        
    }


    void Update()
    {
        
    }

     void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Decrement"))
        {
           Destroy(gameObject);

            ScoreManager.instance.DecrementScore();

        }else if (collision.gameObject.CompareTag("Increment"))
        {
            Destroy(gameObject);

            ScoreManager.instance.IncrementScore();
        }
    }

    void OnTriggerExit2D (Collider2D collision)
    {

    }
    void OnTriggerStay2D (Collider2D collision)
    {
        
    }

}

