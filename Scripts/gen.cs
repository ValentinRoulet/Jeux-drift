using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gen : MonoBehaviour
{
    public GameObject platform;
    private float timer = 0;
    private float destroyTimer = 0;
    private float waitTime = 1;
    private float destroyWaitTime = 4;
    public GameObject Road, Corner;
    private Vector3 PosActuelle;


    void Start()
    {
        Vector3 PosActuelle = new Vector3(0,0,0);
    }

    
    void Update()
    {

        if (timer > waitTime)
        {

            Route();
            RouteTournerG();
            
            timer = 0;
        }
        else
        {
            timer += Time.deltaTime;
        }
        
        
        Debug.Log( "Timer : " + timer);
    }

    void Route()
    {
        GameObject road = Instantiate(Road, new Vector3(0, 0, 6) + PosActuelle, new Quaternion(0f,0f,0f,0f) );
        PosActuelle = road.transform.position;
        Destroy(road, 5);
        
    }
    void Route90()
    {
        GameObject road = Instantiate(Road, new Vector3(0, 0, 6) + PosActuelle, Quaternion.identity );
        PosActuelle = road.transform.position;
        Destroy(road, 5);

    }

    void RouteTournerG() //rotation (0.71f, -20.81f, -94.52f)
    {
        GameObject corner = Instantiate(Corner, new Vector3(0.72f, -20.82, -94.52f) + PosActuelle, Quaternion.identity);
        PosActuelle = corner.transform.position;
        Destroy(corner, 5);
    }

}


