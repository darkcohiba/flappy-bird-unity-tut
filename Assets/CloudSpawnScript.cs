using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawnScript : MonoBehaviour
{
    public GameObject cloud;
    private float startTime;
    private float interval = 2f; // Time interval in seconds

    // Start is called before the first frame update
    void Start()
    {
        // startTime = Time.time;
        spawnCloud();
    }

    // Update is called once per frame
    void Update()
    {
        float elapsedTime = Time.time - startTime;

        if (elapsedTime >= interval)
        {
            // Perform your actions here
            Debug.Log("One second has passed!");
            spawnCloud();

            // Reset the start time
            startTime = Time.time;
        }
    }

    void spawnCloud()
    {
        float lowestPoint = -8.1f;
        float highestPoint = 8.3f;
        float yCoord = Random.Range(lowestPoint, highestPoint);
        Instantiate(cloud, new Vector3(transform.position.x, yCoord, 0), transform.rotation);

    

    }
}
