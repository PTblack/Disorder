using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2Button : MonoBehaviour
{
    [SerializeField]
    GameObject doorToOpen;

    private bool pressedDown;

    private void FixedUpdate()
    {
        if (pressedDown)
            doorToOpen.GetComponent<Stage2ElevatorBehaviour>().openClosed = true;
        else
            doorToOpen.GetComponent<Stage2ElevatorBehaviour>().openClosed = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!pressedDown && collision.CompareTag("Object"))
        {
            pressedDown = true;
            gameObject.transform.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y - 0.2f);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(pressedDown && collision.CompareTag("Object"))
        {
            pressedDown = false;
            gameObject.transform.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y + 0.2f);
        }
    }
}
