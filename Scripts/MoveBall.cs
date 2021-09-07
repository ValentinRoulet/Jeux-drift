using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject camera;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKey(KeyCode.Z))
        {
            rb.velocity = new Vector3(0, 0, 10);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector3(0, 0, -10);
        }
        else if(Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector3(10, 0, 0);
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            rb.velocity = new Vector3(-10, 0, 0);
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            rb.velocity = new Vector3(0, 10, 0);
        }
        else if (Input.GetKey(KeyCode.LeftControl))
        {
            rb.velocity = new Vector3(0, -10, 0);
        }
        else
        {
            rb.velocity = new Vector3(0, 0, 0);
        }

        

        Vector3 offset = new Vector3(0,-2,10);
        camera.transform.position = transform.position - offset ;





    }
}
