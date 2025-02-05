using UnityEngine;

public class ScoreBox : MonoBehaviour
{
    public int ScoreAmount = 100;

    private ScoreManager scoreManager;

    void Start()
    {
        scoreManager = FindFirstObjectByType<ScoreManager>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {

        Debug.Log(col.gameObject.tag + " "+col.gameObject.name);

        if(!col.gameObject.CompareTag("Player"))
            return;

        if(scoreManager)
        {
            scoreManager.AddScore(ScoreAmount);
        }

        // Debug.Log("Add "+ ScoreAmount + " to score");
    }
}
