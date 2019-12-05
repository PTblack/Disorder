using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 movementVector;
    private bool isGrounded;

    private const float speed = 50f;
    [SerializeField] private int timer = 0;
    [SerializeField] private LayerMask ignoreLayers = 0;

    bool A;
    bool D;
    bool jump;

    bool OnGround
    {
        get
        {
            Collider2D collider = Physics2D.OverlapCircle(transform.position, 5.0f, LayerMask.GetMask("Platforms"));
            return (collider != null);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, 1, ~ignoreLayers).collider != null;
        A = Input.GetKey(KeyCode.A);
        D = Input.GetKey(KeyCode.D);
        jump = Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.X);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.DrawRay(transform.position, Vector2.down * 1, Color.red, 0);
        Move();
    }

    private void Move()
    {
        movementVector = rb.velocity;

        if (A)
            movementVector.x -= speed * Time.fixedDeltaTime;

        if (D)
            movementVector.x += speed * Time.fixedDeltaTime;

        if (jump && timer <= 5)
        {
            timer++;

            if (timer <= 5)
                movementVector.y += 300 * Time.fixedDeltaTime;
        }
        else if (isGrounded)
            timer = 0;


        movementVector.x = Mathf.Clamp(movementVector.x, -10, 10);
        rb.velocity = movementVector;
    }
}
