using UnityEngine;
using UnityEngine.InputSystem;


public class Shoot : MonoBehaviour
{
    public PlayerInput playerInput;

    //input actions
    private InputAction ShootCmd;
    //bullet spawning
    public GameObject BulletPref;

    void Start()
    {
        playerInput.ActivateInput();
        ShootCmd = playerInput.actions.FindAction("Shoot");

    }

    void Update()
    {
        if (ShootCmd.WasPressedThisFrame())
        {
            SpawnBullet();
        }

        if (TimerCountdown.instance.timer <= 0)
        {
            playerInput.DeactivateInput();
        }
    }

     void SpawnBullet()
    {     
            Instantiate(BulletPref, transform.position, Quaternion.identity);
    }
}
