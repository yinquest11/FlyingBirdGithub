using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] SpawnPerfan;
    public float SpawnInterval;

    private float timer = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = SpawnInterval;

        int random = Random.Range(0,SpawnPerfan.Length);
        GameObject.Instantiate(SpawnPerfan[random],transform.position,transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {
        if(timer>0f)
        {
            timer -= Time.deltaTime;
            return;
        }

        timer = SpawnInterval;

        if(SpawnPerfan == null)
            return;

        int random = Random.Range(0,SpawnPerfan.Length);

        GameObject.Instantiate(SpawnPerfan[random],transform.position,transform.rotation);


    }
}
