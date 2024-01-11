using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Crate01Prefab; // Reference to the object prefab to spawn
    private Vector3 spawnAreaSize = new Vector3(100f, 100f, 100f); // Size of the spawn area, initialized with values
    private float minSpawnDelay = 1f; // Minimum delay between spawns, initialized with a value
    private float maxSpawnDelay = 3f; // Maximum delay between spawns, initialized with a value

    void Start()
    {
        // Call the SpawnObjects() function to start spawning objects
        SpawnObjects();
    }

    void SpawnObjects()
    {
        // Generate random positions within the spawn area
        Vector3 spawnPosition = new Vector3(
            Random.Range(transform.position.x - spawnAreaSize.x / 2, transform.position.x + spawnAreaSize.x / 2),
            transform.position.y,
            Random.Range(transform.position.z - spawnAreaSize.z / 2, transform.position.z + spawnAreaSize.z / 2)
        );

        // Instantiate the object prefab at the random position
        Instantiate(Crate01Prefab, spawnPosition, Quaternion.identity);

        // Call the SpawnObjects() function again after a random delay within the specified range
        Invoke("SpawnObjects", Random.Range(minSpawnDelay, maxSpawnDelay));
    }
}
