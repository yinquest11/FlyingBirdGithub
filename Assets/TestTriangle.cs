using UnityEngine;

public class TestTriangle : MonoBehaviour
{
    Rigidbody2D rb;
    public Vector2 speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         rb = GetComponent<Rigidbody2D>();

        
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(speed * Time.deltaTime);
        Debug.Log(rb.linearVelocity);
    }
}
