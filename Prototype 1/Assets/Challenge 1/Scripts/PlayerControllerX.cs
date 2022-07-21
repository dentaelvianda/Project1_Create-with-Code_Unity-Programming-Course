﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float speed =20.0f;
    private float rotationSpeed = 40.0f;
    private float verticalInput;
    private float rotationPropeller = 200.0f;
    public GameObject propeller;
  

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
   
        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed *Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime*verticalInput);

        // Rotate Propellor
        propeller.transform.Rotate(Vector3.forward * Time.deltaTime * rotationPropeller);

        
    }
}
