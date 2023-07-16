using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }else {
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe() {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        float yCoord = Random.Range(lowestPoint, highestPoint);
        Debug.Log(yCoord);
        // Debug.Log(transform.position.x);
        if (yCoord > 8.8f)
        {
            yCoord = 8.7f;
        }
        if (yCoord < -8.5f)
        {
            yCoord = -8.3f;
        }



        Instantiate(pipe, new Vector3(transform.position.x, yCoord, 0), transform.rotation);
    }
}
