using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]private float speed;
    Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        OnMove();
    }

    void OnMove()
    {
        float movement = Input.GetAxis("Horizontal");

        rb.linearVelocity = new Vector2(movement * speed, rb.linearVelocity.y);

        if(movement > 0)
        {
            transform.eulerAngles = new Vector2(0, 0);
        }

        if (movement < 0)
        {
            transform.eulerAngles = new Vector2(0, 180);
        }


    }
}
