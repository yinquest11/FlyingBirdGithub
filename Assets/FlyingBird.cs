using UnityEngine;

public class FlyingBird : MonoBehaviour
{
    public float JumpForce = 250f;

    private Rigidbody2D rigidbody;
    private Collider2D collider;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        collider = GetComponent<Collider2D>();
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(rigidbody)
            {
                rigidbody.linearVelocity = Vector2.zero;
                rigidbody.AddForce(Vector2.up * JumpForce );
            }
        }
        
    }
}
