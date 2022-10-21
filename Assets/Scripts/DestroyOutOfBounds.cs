using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 30f;
    public float lowerBound = -10f;
    public float sideBound = 30f;

    // Update is called once per frame
    void Update()
    {
        //If an object goes above the view of the player, it will get destroyed
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        //If an object (read: animal) goes below the player (gets past the player), it'll delete
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
            Debug.Log("Game over");
        }

        else if (transform.position.x > sideBound)
        {
            Debug.Log("Game over");
            Destroy(gameObject);
        }

        else if (transform.position.x < -sideBound)
        {
            Debug.Log("Game over");
            Destroy(gameObject);
        }

    }
}
