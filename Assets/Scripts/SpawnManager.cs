using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnForwardRangeX = 20;
    private float spawnForwardPosZ = 20;

    public float spawnSideRangeZ = 16;
    public float spawnSidePosX = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimalForward", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalRight", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalLeft", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void SpawnRandomAnimalForward()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnForwardRangeX, spawnForwardRangeX), 0, spawnForwardPosZ);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
    private void SpawnRandomAnimalRight()
    {
        Vector3 spawnPos = new Vector3(spawnSidePosX, 0,  Random.Range(5, spawnSideRangeZ));
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnRotation = new Vector3(animalPrefabs[animalIndex].transform.rotation.x,
            animalPrefabs[animalIndex].transform.rotation.y - 90f, animalPrefabs[animalIndex].transform.rotation.z);
        Instantiate(animalPrefabs[animalIndex], spawnPos,Quaternion.Euler(spawnRotation));
    }
    private void SpawnRandomAnimalLeft()
    {
        Vector3 spawnPos = new Vector3(spawnSidePosX, 0, Random.Range(5, spawnSideRangeZ));
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnRotation = new Vector3(animalPrefabs[animalIndex].transform.rotation.x,
            animalPrefabs[animalIndex].transform.rotation.y + 90f, animalPrefabs[animalIndex].transform.rotation.z);
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(spawnRotation));
    }
}
