
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn; // Assign your prefab in the Inspector
    public Transform spawnPoint;     // Assign your spawn point in the Inspector

    void Start()
    {
        SpawnObject();
    }

    void SpawnObject()
    {
        Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);
    }
}
