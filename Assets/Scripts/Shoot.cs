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
        ShootCmd = playerInput.actions.FindAction("Shoot");
    }

    void Update()
    {
        if (ShootCmd.WasPressedThisFrame())
        {
            SpawnBullet();
        }
    }

     void SpawnBullet()
    {     
            Instantiate(BulletPref, transform.position, Quaternion.identity);
    }
}
