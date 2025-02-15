using UnityEngine;

public class BgmPlayer : MonoBehaviour
{
    public AudioClip Clip;
    private AudioSource source;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(Clip==null)
            return;
            
        source = GetComponent<AudioSource>();

        source.clip = Clip;
        source.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
