using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PC_Prot2 : MonoBehaviour
{

    [HideInInspector] public Vector2 movementDirection;
    public float speed = 10f;
    public float xRange = 10;
    public GameObject projectilePrefab;


    void Update()
    {
        // Moves the player
        transform.Translate(Vector3.forward * Time.deltaTime * speed * movementDirection.y);
        transform.Translate(Vector3.right * Time.deltaTime * speed * movementDirection.x);

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
}
