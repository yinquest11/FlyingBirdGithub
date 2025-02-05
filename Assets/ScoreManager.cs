using UnityEngine;

public class ScoreManager : MonoBehaviour
{
   public int CurrentScore =0;

   public void AddScore(int score)
   {
    CurrentScore += score;
   }
}
