using UnityEngine;
using UnityEngine.SceneManagement;

public class GoHome : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void GoPage()
    {
        SceneManager.LoadScene("Page");
    }
}
