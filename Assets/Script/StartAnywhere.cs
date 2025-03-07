using System;
using System.Numerics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartAnywhere : MonoBehaviour
{

    public string scene = "SampleScene";

    private GameObject graphic;
    
    public float Velocity = 2;

    private bool canGo = false;

    // Update is called once per frame
    public void Update()
    {
         if(Input.GetKeyDown(KeyCode.Space)||Input.GetMouseButtonDown(0))
        {
            canGo = true;
            Debug.Log("canGo=true");
        }
        
        if(canGo)
        {
            graphic = GameObject.Find("Graphic");
            UnityEngine.Vector3 currentPosition  = graphic.transform.position;
            currentPosition.x += Time.deltaTime * Velocity;
            graphic.transform.position = currentPosition;

            if(graphic.transform.position.x>=0)
            {
                SceneManager.LoadScene(scene);
                Debug.Log("Again");

            }

        }

         
        

         
        
         
    }

       
}

    

