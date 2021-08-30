using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }

    void ProcessThrust()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Pressed SPACE - Thrusting");
            rb.AddRelativeForce(0, 1, 0);
        }        
    }

    void ProcessRotation()
    {
        if(Input.GetKey(KeyCode.A))
        {
            Debug.Log("Rotate Left");
        }
        else if(Input.GetKey(KeyCode.D))
        {
            Debug.Log("Rotate Right");
        }
    }
}