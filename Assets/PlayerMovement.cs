using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        if(Input.GetKey(KeyCode.W))
        {
            rb.position += new Vector2(0, 0.1f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.position += new Vector2(0, -0.1f);
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
