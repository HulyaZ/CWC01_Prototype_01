using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoller : MonoBehaviour
{
    public float playerSpeed = 20.0f;
    float turnSpeed = 45.0f;
    float horizontalInput;
    float forwardInput;

    void Start()
    {
        
    }

   
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward*Time.deltaTime * playerSpeed * forwardInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
        
    }
}
