using System.Collections.Generic;
using UnityEngine;

public class Stage3FallingObject : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float minX;
    [SerializeField] float maxX;

    [SerializeField] Sprite somSprite;
    [SerializeField] Sprite visaoSprite;
    [SerializeField] Sprite tatoSprite;

    Rigidbody2D rigidBody;
    SpriteRenderer spriteRenderer;

    System.Random csharpRnd = new System.Random();

    float timer;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        randomType();
        switch(tag)
        {
            case "Som":
                spriteRenderer.sprite = somSprite;
                break;
            case "Visao":
                spriteRenderer.sprite = visaoSprite;
                break;
            case "Tato":
                spriteRenderer.sprite = tatoSprite;
                Debug.Log("É TATO!!!!!!!!!");
                break;
            default:
                break;
        }

        transform.position = new Vector3(Random.Range(minX, maxX), 6.13f, 0);
        timer = 6;
    }

    void Update()
    {
        timer -= 1 * Time.deltaTime;

        if (timer <= 0) Destroy(gameObject);
    }
    void FixedUpdate()
    {
        rigidBody.velocity = new Vector2(0, -speed);

    }

    void randomType()
    {

        int typeInt = csharpRnd.Next(0,2);

        tag = Types.typeList[typeInt];

    }
}
