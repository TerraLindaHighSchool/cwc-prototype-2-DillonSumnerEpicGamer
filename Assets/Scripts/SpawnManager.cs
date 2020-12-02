using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    private float xSpawnRange = 20.0f;
    private float zSpawnPoint = 20.0f;
    private float startDelay = 2.0f;
    private float spawnInterval = 1.5f;
   
    // Start is called before the first frame update
    void Start()
    {
        //spawns animals by calling the function
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //this function will spawn a random animal but i want to re do it so you can insert parameters but im just going to follow the videos
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-xSpawnRange, xSpawnRange), 0, zSpawnPoint);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
