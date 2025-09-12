using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //rigid body
    private Rigidbody rb;
    //speed
    public float speed = 50.0f;
    //move inputs
    private float moveX, moveY;

    //gamemanager
    public GameObject gameManager;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        moveY = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector3(moveX * speed * Time.deltaTime, moveY * speed * Time.deltaTime, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("hazard"))
        {
            gameManager.GetComponent<GameManager>().displayLose();
            this.gameObject.SetActive(false);
        }
        else if (collision.gameObject.CompareTag("win"))
        {
            gameManager.GetComponent<GameManager>().displayWin();
            this.gameObject.SetActive(false);
        }
    }
}
