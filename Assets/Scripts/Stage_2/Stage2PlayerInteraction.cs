using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2PlayerInteraction : MonoBehaviour
{
    private bool nearInteractable;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        nearInteractable = true;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        // This statement is used solely for the player to be able to 'grab' onto objects and pull them.
        // It checks if we have a RigidBody, and if we do, we start 'pulling'.
        if(Input.GetKey(KeyCode.Z) && collision.GetComponent<Rigidbody2D>() != null)
        {
            collision.GetComponent<Rigidbody2D>().velocity = new Vector2(gameObject.GetComponent<Rigidbody2D>().velocity.x, 0);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        nearInteractable = false;
    }
}
