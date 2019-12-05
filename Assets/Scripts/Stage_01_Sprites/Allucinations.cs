using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Allucinations : MonoBehaviour
{
    [SerializeField] Transform playerPosition;
    [SerializeField] float speed;

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position,
            playerPosition.position, speed * Time.deltaTime);
    }
}
