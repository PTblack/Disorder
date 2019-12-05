using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Slider happinessBar;


    float hAxis;
    float vAxis;

    float happiness;
    int happinessDisplay;

    Rigidbody2D rigidBody;




    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();

        happiness = 100;
        happinessDisplay = 100;

        happinessBar.value = happinessDisplay;
    }

    void Update()
    {
        hAxis = Input.GetAxis("Horizontal");
        vAxis = Input.GetAxis("Vertical");

        happiness -= 2 * Time.deltaTime;
        happinessDisplay = (int)Math.Round(happiness, 0);

        if (happinessDisplay % 2 == 0) Debug.Log(happinessDisplay);

        happinessBar.value = happinessDisplay;

    }

    void FixedUpdate()
    {
        rigidBody.velocity = new Vector2(hAxis * speed, vAxis * speed);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Heart")
        {
            happiness += 20;
            if (happiness > 100) happiness = 100;
            collider.GetComponent<SpriteRenderer>().enabled = false;
            collider.GetComponent<Collider2D>().enabled = false;
        }
        if (collider.tag == "Voz")
        {
            collider.GetComponent<SpriteRenderer>().enabled = false;
        }

        if (collider.tag == "Exit")
        {
            SceneManager.LoadScene("Hub");

        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.tag == "Voz")
        {
            collider.GetComponent<SpriteRenderer>().enabled = true;
        }
    }
}
