using UnityEngine;

public class KillZone : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        if(!col.gameObject.CompareTag("Player"))
            return;

       Destroy(col.gameObject);
    }

        
}
