using JetBrains.Annotations;
using TMPro;
using Unity.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class LightDark : MonoBehaviour
{
    public GameObject GoOutWater;
    

    public GameObject AfterEffect;
    public GameObject AfterAfterEffect;
    

    bool canUp = false;

    public AudioClip[] Clips;

   private AudioSource source;
    
   public float MinPitch = 0.9f;
   public float MaxPitch = 1.5f;
   
    public bool canDown = false;

    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         source = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        

        if(transform.position.y>=3.1&&canUp)
        {       
            int randomClips = Random.Range(0,Clips.Length);
            float randomPich = Random.Range(0,Clips.Length);

            float randomPitch = Random.Range(MinPitch,MaxPitch);
            source.pitch = randomPitch;
            source.PlayOneShot(Clips[randomClips]);  
            
            
            Vector3 upWater = new Vector3 (0f,5.12f,50f);
            AfterEffect = Instantiate(GoOutWater,upWater,Quaternion.identity);
            Invoke("DestroyAfter",0.8f);
            
            
               
            
            canUp = false;
            

        }


        if(canDown&&transform.position.y<=3.1)
        {       
            
            int randomClips = Random.Range(0,Clips.Length);
            float randomPich = Random.Range(0,Clips.Length);

            float randomPitch = Random.Range(MinPitch,MaxPitch);
            source.pitch = randomPitch;
            source.PlayOneShot(Clips[randomClips]);  
            
            
            Vector3 upWater = new Vector3 (0f,5.12f,50f);
            AfterAfterEffect = Instantiate(GoOutWater,upWater,Quaternion.identity);
            Invoke("DestroyAfterAfter",0.8f);
            
            
               
            
            canDown = false;
            

        }

        if(transform.position.y>=5.2)
        {         
            canDown = true;
            
 
        }



        if(transform.position.y<3.1f)
        {         
            canUp = true;

            if(AfterEffect)
            {
                Invoke("DestroyAfter",0f);
            }
        }
        
    }

    public void DestroyAfter()
    {
        Destroy(AfterEffect,1);
    }

    public void DestroyAfterAfter()
    {
        Destroy(AfterAfterEffect);
    }

   
}
