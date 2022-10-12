using UnityEngine;
using UnityEngine.InputSystem;

public class PC_Prot2 : MonoBehaviour
{

    [HideInInspector] public Vector2 movementDirection;
    public float speed = 10f;
    public float xRange = 10;
    public GameObject projectilePrefab;
    public GameObject spawnManager;


    void Update()
    {
        // Moves the player
        transform.Translate(movementDirection.y * speed * Time.deltaTime * Vector3.forward);
        transform.Translate(movementDirection.x * speed * Time.deltaTime * Vector3.right);

        // Keeps the player in bounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }



    }

    public void OnMove(InputValue value)
    {
        // Sets the movement direction from the value of the input value WASD
        movementDirection = value.Get<Vector2>();

    }

    public void OnFire()
    {
        // Launch a projectile OnFire button pressed
        Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
    }

    //Not using the jump key to invoke this anymore, but here is how to use a button press to send a message to something else.
    //public void OnJump()
    //{
    //    //When jump is pressed, sends a message to the spawn manager (assigned in inspector) to fire the event called SpawnAnimals
    //    spawnManager.SendMessage("SpawnAnimals");
    //}
}
