using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float jumpForce = 7;
    public LogicScript logic;
    public bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Rotate(0, 0, Random.Range(0, 360));
        if (Input.GetKeyDown(KeyCode.Space) == true  && birdIsAlive == true)
        {
            jump();
        }
    }

    void jump()
    {
        myRigidbody.velocity = Vector2.up * jumpForce;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
