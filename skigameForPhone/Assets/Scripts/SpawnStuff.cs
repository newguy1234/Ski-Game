using UnityEngine;

public class SpawnStuff : MonoBehaviour
{
    // Array of spawn points
    public Transform[] spawnPoints;

    // Array of objects to spawn
    public GameObject[] objectsToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        // Start spawning objects every 10 seconds
        InvokeRepeating(nameof(SpawnObjectsAtRandomPoints), 0f, Random.Range(1f,4f));
    }

    // Method to spawn objects at all spawn points


    // Method to spawn a random object at a specific spawn point
    void SpawnRandomObjectAtPoint(Transform spawnPoint)
    {
        Debug.Log("Spawn Check");
        // Select a random object from the array
        int randomObjectIndex = Random.Range(0, objectsToSpawn.Length);

        // Instantiate the random object at the specified spawn point
        Instantiate(objectsToSpawn[randomObjectIndex], spawnPoint.position, spawnPoint.rotation);
    }

    // Example of spawning objects at random points
    void SpawnObjectsAtRandomPoints()
    {
        foreach (Transform spawnPoint in spawnPoints)
        {
            // There's a chance to not spawn anything at a spawn point
            if (Random.value > 0.5f) // 50% chance to spawn
            {
                SpawnRandomObjectAtPoint(spawnPoint);
            }
        }
    }

    // Update is kept here for additional functionality, like manual spawning
    void Update()
    {
        // Example: Spawn a random object at a random point when the player presses the spacebar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int randomIndex = Random.Range(0, spawnPoints.Length);
            SpawnRandomObjectAtPoint(spawnPoints[randomIndex]);
        }
    }
}
