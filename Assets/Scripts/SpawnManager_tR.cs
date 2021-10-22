
using UnityEngine;

public class SpawnManager_tR : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeZ = 14;
    private float spawnPosX = 40;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 2, 9.5f);
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPosHorizontalZLeft = new Vector3(-spawnPosX, 0, Random.Range(-spawnRangeZ, spawnRangeZ));
        Instantiate(animalPrefabs[animalIndex], spawnPosHorizontalZLeft, animalPrefabs[animalIndex].transform.rotation);
    }
}
