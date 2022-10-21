using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //If an object with rigidbody collides, it deletes itself then deletes the other thing it colliding with as well.
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("PLAYER DOWN");
            Destroy(gameObject);

        }
        else
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        
    }
}
