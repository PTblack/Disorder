using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2ElevatorBehaviour : MonoBehaviour
{
    public bool openClosed;

    private SpriteRenderer sprite;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    private void LateUpdate()
    {
        UpdateVisuals();
    }

    private void UpdateVisuals()
    {
        if (openClosed)
            sprite.color = Color.green;
        else
            sprite.color = Color.red;
    }
}
