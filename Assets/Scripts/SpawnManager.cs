using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20f;
    private float spawnRangeZ = 20f;
    private float startDelay = 2f;
    private float spawnInterval = 1.5f;


    private void Start()
    {
        //After startDelay seconds, the SpawnAnimals method will be invoked every spawnInterval seconds.
        InvokeRepeating("SpawnAnimals", startDelay, spawnInterval);
    }
    void SpawnAnimals()
    {
        //makes a new animal index and gets a random index. Creates a new random spawn position as well.
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);

        //When called to from the PC, will fire this event to spawn animals
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }

}
