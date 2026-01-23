using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

public PlayerInput playerInput;

private InputAction action1;
private InputAction action2;
private InputAction MoveAction;

public float speed = 1.0f;
private Vector2 direction;
private Vector2 velocity;


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

        Debug.Log(MoveAction.ReadValue<Vector2>());

        direction = MoveAction.ReadValue<Vector2>();

        velocity = speed * direction * Time.deltaTime;

        transform.Translate(velocity);
    }


    void LogHelloWorld()
    {
        Debug.Log("Hello, World!");
    }

    void LogHiWorld()
    {
        Debug.Log("Hi, World!");
    }


}
