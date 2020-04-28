using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Reference to the player's heatlh.
    public GameObject square, circle, tri, hex;                // The enemy prefab to be spawned.
    public float spawnRate = 3f;            // How long between each spawn.
   
    
    // public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.
                                       


    void Start()
    {
        // Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
        InvokeRepeating("Spawn", spawnRate, spawnRate);
    }


    void Spawn()
    {
        // Find a random index between zero and one less than the number of spawn points.
          int whatToSpawn = Random.Range(0,5);

        switch (whatToSpawn)
    {
            case 1:
        // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
        Instantiate(circle, transform.position, Quaternion.identity);
                break;
            case 2:
                // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
                Instantiate(square, transform.position, Quaternion.identity);
                break;
            case 3:
                // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
                Instantiate(tri, transform.position, Quaternion.identity);
                break;
            case 4:
                // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
                Instantiate(hex, transform.position, Quaternion.identity);
                break;
        }
        //new Vector3(0, 0, -1)

    }



}
