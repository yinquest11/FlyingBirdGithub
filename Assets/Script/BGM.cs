using System.Diagnostics;
using UnityEngine;

public class BGM : MonoBehaviour
{
    public AudioClip Clip;
    private AudioSource source;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        source = GetComponent<AudioSource>();
        if(Clip&&source)
        {
            source.clip = Clip;
            source.PlayDelayed(3F); 
        }
        
        
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
