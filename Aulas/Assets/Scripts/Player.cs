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

        rb.velocity = new Vector2(movement * speed, rb.velocity.y);
    }
}
