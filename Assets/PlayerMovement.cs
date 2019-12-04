using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    private Vector2 acceleration;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Acceleration();
        Movement();
    }

    private void Acceleration()
    {
        if (Input.GetKey(KeyCode.S))
        {
            acceleration += new Vector2(0, Input.GetAxis("Horizontal"));
        }
    }

    private void Movement()
    {
        if(Input.GetKey(KeyCode.W))
        {
            
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(acceleration);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.position += new Vector2(-0.1f, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.position += new Vector2(0.1f, 0);
        }
    }
}
