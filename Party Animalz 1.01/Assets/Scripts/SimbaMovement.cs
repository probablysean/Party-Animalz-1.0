using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimbaMovement : MonoBehaviour
{

    public float yAxis;
    public float xAxis;
    public float moveSpeed = 2f;

    public Rigidbody2D simbaRb;

    public Vector2 movement;


    // Update is called once per frame
    void Update()
    {
        if (!Input.GetKey("w") && !Input.GetKey("a") && !Input.GetKey("s") && !Input.GetKey("d"))
        {
            movement.x = 0;
            movement.y = 0;
        }

        if (Input.GetKeyDown("s"))
        {
            movement.y = -1;
            movement.x = 0;
        }

        if (Input.GetKeyDown("w"))
        {
            movement.y = 1;
            movement.x = 0;
        }

        if (Input.GetKeyDown("d"))
        {
            movement.x = 1;
            movement.y = 0;
        }

        if (Input.GetKeyDown("a"))
        {
            movement.x = -1;
            movement.y = 0;
        }

    }

    void FixedUpdate()
    {
        simbaRb.MovePosition(simbaRb.position + movement * moveSpeed * Time.deltaTime); 
    }
}
