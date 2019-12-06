using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteSpawn : MonoBehaviour
{
    [SerializeField] GameObject fallingObject;


    public float timer = 2;

    void Update()
    {
        timer -= 1 * Time.deltaTime;

        if (timer <= 0)
        {
            Instantiate(fallingObject);
            timer = 2;
        }
    }
}
