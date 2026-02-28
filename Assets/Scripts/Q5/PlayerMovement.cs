using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    
public PlayerInput playerInput;

private InputAction MoveAction;
    
//player movement 
public float speed = 1.0f;
private Vector2 direction;
private Vector2 velocity;
private Vector2 LastDirection;

//Animation

Animator animator;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MoveAction = playerInput.actions.FindAction("Move");
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveInput();

    }

void MoveInput()
{
    

    //=====================Player Input=======================//
        direction = MoveAction.ReadValue<Vector2>();

        if (MoveAction.IsPressed())
        {
            animator.SetBool("isWalking", true);
            LastDirection = direction;

            animator.SetFloat("InputX", direction.x);
            animator.SetFloat("InputY", direction.y);

        }else if (MoveAction.WasReleasedThisFrame())
        {
            LastDirection = direction;
            animator.SetFloat("LastInputX", LastDirection.x);
            animator.SetFloat("LastInputY", LastDirection.y);
            animator.SetBool("isWalking", false);
        }

        velocity = speed * direction * Time.deltaTime;

        transform.Translate(velocity);
 //========================================================//
}




}
