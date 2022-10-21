using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX2 : MonoBehaviour
{
    public GameObject dogPrefab;
    private float dogDelay = 1f;
    private float dogTimer;

    // Update is called once per frame
    void Update()
    {

        dogTimer += Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && (dogTimer > dogDelay))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            dogTimer = 0f;
        }
    }
}
