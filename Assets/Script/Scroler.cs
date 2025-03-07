using UnityEngine;

public class Scroler : MonoBehaviour
{

    public float Speed = 2f;
    private SpriteRenderer spriteRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(spriteRenderer==null)
            return;
        
        Vector2 offset = new Vector2(Time.time * Speed,0);
        spriteRenderer.material.mainTextureOffset = offset;
        
    }
}
