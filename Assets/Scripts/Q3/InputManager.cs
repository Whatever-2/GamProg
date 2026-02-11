using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private PlayerInput playerInput;

    void Start()
    {
        // Get the PlayerInput component on this or another GameObject
        playerInput = GetComponent<PlayerInput>();
    }


    public void DisablePlayerInput()
    {
        // Deactivates all input handling for this specific player
        playerInput.DeactivateInput();
    }

    public void EnablePlayerInput()
    {
        // Re-activates input handling (enables the default action map)
        playerInput.ActivateInput();
    }
}
