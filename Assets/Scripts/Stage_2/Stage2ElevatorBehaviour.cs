using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2ElevatorBehaviour : MonoBehaviour
{
    public bool openClosed;
    public Transform teleportDestination;
    public Transform teleportDestination2;
    private SpriteRenderer sprite;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    /*private void LateUpdate()
    {
        UpdateVisuals();
    }

    private void UpdateVisuals()
    {
        if (openClosed)
            sprite.color = Color.green;
        else
            sprite.color = Color.red;
    }*/
    void OnTriggerStay2D(Collider2D c)
    {

        //transport
        if (c.gameObject.tag == "E1" && Input.GetKey(KeyCode.W))
        {
            //  WaitForSeconds nfs = new WaitForSeconds(2);
            transform.position = teleportDestination.position;
        }
        else if (c.gameObject.tag == "E2" && Input.GetKey(KeyCode.S))
        {
            transform.position = teleportDestination2.position;
        }

    }
}
