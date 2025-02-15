using UnityEngine;
using UnityEngine.SceneManagement;


public class KillZone : MonoBehaviour 
{
public AudioClip[] Clips;

   private AudioSource source;

   private GameObject background;
   private Mover scroler;

   public float MinPitch = 0.9f;
   public float MaxPitch = 1.5f;

   public bool TheGameEnd = false;

   private GameManager gameManager;

   
    
    private void OnCollisionEnter2D(Collision2D col)
    {

        if(!col.gameObject.CompareTag("Player"))
            {
                return;
            }

       Destroy(col.gameObject.GetComponent<LightDark>().AfterEffect);
       Destroy(col.gameObject);


        
        source = GetComponent<AudioSource>();
        if(source&&Clips.Length>0)
        {
            int randomClips = Random.Range(0,Clips.Length);
            float randomPich = Random.Range(0,Clips.Length);

            float randomPitch = Random.Range(MinPitch,MaxPitch);
            source.pitch = randomPitch;
            source.PlayOneShot(Clips[randomClips]);  
        }  


        TheGameEnd = true;
        

    }

    public void Update()
    { 
        if(TheGameEnd==true)
        {
            
            
            if(gameManager)
            {
                background.GetComponent<Scroler>().enabled = false;
                scroler.enabled = false;
                foreach(GameObject g in gameManager.BigTrunOnWhenEnd)
                {
                    g.SetActive(true);
                    
                }

                foreach(GameObject g in gameManager.BigTrunOfWhenEnd)
                {
                    g.SetActive(false);
                }
                


            }

        }
    }

    public void Start()
    {
        if(SceneManager.GetActiveScene().name!="Page")
        {
        scroler = GetComponentInParent<Mover>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        background = GameObject.Find("Background");
        }
    }



}
