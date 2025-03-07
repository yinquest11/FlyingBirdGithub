using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
   public int CurrentScore = 0;
   public AudioClip Clip;

   

   private AudioSource source;
   public void AddScore(int score)
   {
     source = GetComponent<AudioSource>();
     source.PlayOneShot(Clip,1F);
     CurrentScore += score;

   }
}
