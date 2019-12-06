using UnityEngine;
using UnityEngine.UI;

public class Stage3Player : MonoBehaviour
{
    private Rigidbody2D rigidBody;

    [SerializeField] private float speed;
    [SerializeField] Slider powerBar;


    float hAxis;
    float power;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();

        powerBar.value = power;

    }

    void Update()
    {
        hAxis = Input.GetAxis("Horizontal");
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        rigidBody.velocity = new Vector2(hAxis * speed, 0);

    }
}
