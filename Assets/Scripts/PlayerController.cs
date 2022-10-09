using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speedVehicle = 15f;
    public float turnSpeed;
    [HideInInspector] public Vector2 movementDirection;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.forward * Time.deltaTime * speedVehicle);

        rb.AddRelativeForce(Vector3.forward * movementDirection.y * Time.deltaTime * speedVehicle, ForceMode.Force);
        transform.Rotate(Vector3.up * movementDirection.x * Time.deltaTime * turnSpeed);


    }

    public void OnMove(InputValue value)
    {
        movementDirection = value.Get<Vector2>();

    }
}
