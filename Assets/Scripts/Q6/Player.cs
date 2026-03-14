using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    
public PlayerInput playerInput;

private InputAction MoveAction; 
protected InputAction Input1;

//player movement 
public float speed = 1.0f;
private Vector2 direction;
private Vector2 velocity;
protected Vector2 LastDirection;

//Animation

//Animator animator;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MoveAction = playerInput.actions.FindAction("Move");
        
        Input1 = playerInput.actions.FindAction("Shoot");
        
        //animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Attack();

    }

void Move()
{
    

    //=====================Player Input=======================//
        direction = MoveAction.ReadValue<Vector2>();

        if (MoveAction.IsPressed())
        {
            //animator.SetBool("isWalking", true);
            LastDirection = direction;

            //animator.SetFloat("InputX", direction.x);
            //animator.SetFloat("InputY", direction.y);

        }else if (MoveAction.WasReleasedThisFrame())
        {
            //animator.SetFloat("LastInputX", LastDirection.x);
            //animator.SetFloat("LastInputY", LastDirection.y);
            //animator.SetBool("isWalking", false);
        }

        velocity = speed * direction * Time.deltaTime;

        transform.Translate(velocity);
 //========================================================//
}

protected virtual void Attack(){}

protected virtual void OnTriggerEnter2D(Collider2D collision)
{
    if (collision.gameObject.CompareTag("Pokeball"))
    {
        Destroy(gameObject);
    }

}
}
