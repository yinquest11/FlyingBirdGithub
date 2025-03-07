using System;
using Unity.VisualScripting;
using UnityEngine;
using Unity.Mathematics;
using Unity.Burst;

public class FishRotate : MonoBehaviour
{
    private FlyingBird player;

    private float currentY;
    private float previousY;

    public float Velocity;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = transform.parent.GetComponent<FlyingBird>();
        currentY = previousY = transform.parent.position.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(player==null)
        return;

        //store the current Y value
        currentY = player.transform.position.y;

        //velocity by minus currentX by previous
        Velocity = currentY - previousY;

        //we do our animation magic
        Velocity*=10;
        Velocity = Mathf.Clamp(Velocity, -1, 1);
        Velocity = math.remap(-1F,1F,0F,1F,Velocity);
        
        transform.rotation = Quaternion.Lerp(Quaternion.Euler(0,0,-20f),Quaternion.Euler(0,0,60f),Velocity);


        //store the previousY

        previousY = player.transform.position.y;
        
    }
}
