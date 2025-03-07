using UnityEngine;

public class Mover : MonoBehaviour
{
    public float MoveSpeed = 100f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x <= -10)
        {
            Destroy(gameObject);
        }
       Vector2 targetMovePos = transform.position;
       targetMovePos.x -= MoveSpeed * Time.deltaTime;

       transform.position = targetMovePos; 
    }
}
