using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 10;
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
            timer = 0f;
        }
    }

    void spawnPipe() {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        float yCoord = Random.Range(lowestPoint, highestPoint);
        Debug.Log(yCoord);
        // Debug.Log(transform.position.x);
        if (yCoord > 8.6f)
        {
            yCoord = 8.5f;
        }else if (yCoord < -5.5f)
        {
            yCoord = -5.3f;
        }
        Debug.Log(yCoord);
        Debug.Log("end of spawn");




        Instantiate(pipe, new Vector3(transform.position.x, yCoord, 0), transform.rotation);
    }
}
