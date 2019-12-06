using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Slider happinessBar;

    [SerializeField] Allucinations a1;
    [SerializeField] Allucinations a2;

    float hAxis;
    float vAxis;

    float happiness;
    int happinessDisplay;

    Rigidbody2D rigidBody;




    private void Start()
    {
        LastScene.GetCurrentSceneName();

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

        happinessBar.value = happinessDisplay;

        if (happiness <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
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

        if (collider.tag == "Alucination")
        {
            happiness -= 10;
        }

        if (collider.tag == "Zone01")
        {
            a1.enabled = true;
        }
        
        if (collider.tag == "Zone02")
        {
            a2.enabled = true;
        }

        if (collider.tag == "Exit")
        {
            if (happiness >= 65) SceneManager.LoadScene("Victory");
            else SceneManager.LoadScene("GameOver");
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.tag == "Voz")
        {
            collider.GetComponent<SpriteRenderer>().enabled = true;
        }

        if (collider.tag == "Zone01")
        {
            a1.enabled = false;
        }
        
        if (collider.tag == "Zone02")
        {
            a2.enabled = false;
        }
    }
}
