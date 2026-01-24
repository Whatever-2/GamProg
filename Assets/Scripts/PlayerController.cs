using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

public PlayerInput playerInput;

//input actions
private InputAction action1;
private InputAction action2;
private InputAction MoveAction;


//player movement 
public float speed = 1.0f;
private Vector2 direction;
private Vector2 velocity;
private Vector2 LastDirection;


//bullet spawning
public GameObject BulletPref;


        void Start()
    {
        action1 = playerInput.actions.FindAction("Action1");
        action2 = playerInput.actions.FindAction("Action2");
        MoveAction = playerInput.actions.FindAction("Move");
    }

 
    void Update()
    {

        //log console message on action butrton press
        if (action1.WasPressedThisFrame())
        {
            LogHelloWorld();
        }
        if (action2.WasPressedThisFrame())
        {
            LogHiWorld();
        }

        //Debug.Log(MoveAction.ReadValue<Vector2>());

        direction = MoveAction.ReadValue<Vector2>();

        if (MoveAction.IsPressed())
        {
            LastDirection = direction;
        }else if (MoveAction.WasReleasedThisFrame())
        {
            LastDirection = direction;
        }

        velocity = speed * direction * Time.deltaTime;

        transform.Translate(velocity);

        if (action1.WasPressedThisFrame())
        {
            Shoot();
        }


    }


    void LogHelloWorld()
    {
        Debug.Log("Hello, World!");
    }

    void LogHiWorld()
    {
        Debug.Log("Hi, World!");
    }

    void Shoot()
    {     
            Instantiate(BulletPref, transform.position, Quaternion.identity);
    }

    void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerExit2D (Collider2D collision)
    {
        
    }
    void OnTriggerStay2D (Collider2D collision)
    {
        
    }

}
