using TMPro;
using UnityEngine;

public class ScoreDispaly : MonoBehaviour
{

    private ScoreManager scoreManager;

    public TMP_Text ScoreUI;
    public TMP_Text FinalScore;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreManager = FindFirstObjectByType<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(ScoreUI == null || scoreManager == null)
        return;

        ScoreUI.text = scoreManager.CurrentScore.ToString();

        

        FinalScore.text = ScoreUI.text;
    }
}
