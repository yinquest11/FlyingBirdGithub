using UnityEngine;

public class FlyingBird : MonoBehaviour
{
    public float JumpForce = 250f;

    private Rigidbody2D rigidbody;
    private Collider2D collider;

    public AudioClip[] Clips;

   private AudioSource source;

   public float MinPitch = 0.9f;
   public float MaxPitch = 1.5f;
    
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        collider = GetComponent<Collider2D>();
        rigidbody = GetComponent<Rigidbody2D>();
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)||Input.GetMouseButtonDown(0))
        {
            if(rigidbody)
            {
                rigidbody.linearVelocity = Vector2.zero;
                rigidbody.AddForce(Vector2.up * JumpForce );
            }

            
            if(source&&Clips.Length>0)
        {
            int randomClips = Random.Range(0,Clips.Length);
            float randomPich = Random.Range(0,Clips.Length);

            float randomPitch = Random.Range(MinPitch,MaxPitch);
            source.pitch = randomPitch;
            source.PlayOneShot(Clips[randomClips]);
        }
        }

        
        
        
    }
}
