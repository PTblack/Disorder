using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2ElevatorManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] elevators;

    private Collider2D[] elevatorColliders;

    private void Start()
    {
        elevatorColliders = GetComponents<Collider2D>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            ElevatorFunction(collision);
    }

    // this does not work as i expected it would work
    private void ElevatorFunction(Collider2D player)
    {
        int counter = 0;

        if (counter <= 0)
            counter = 0;
        else if (counter >= elevators.Length)

            counter = elevators.Length;

        // count up the array when going up and when going down count down duh
        if (Input.GetKey(KeyCode.W))
        {
            counter++;
            player.transform.position = elevators[counter].transform.position;
        }
        else if(Input.GetKey(KeyCode.S))
        {
            counter--;
            player.transform.position = elevators[counter].transform.position;
        }
    }
}
