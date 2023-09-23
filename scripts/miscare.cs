using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float rotationSpeed = 100.0f; 
    public float moveSpeed = 30.0f;     
    public float glideSpeed = 20.0f;    

    void Update()
    {


        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        float QE= Input.GetAxis("QE");
        Vector3 inclinare =new Vector3(verticalInput ,QE,horizontalInput);
        transform.Rotate(inclinare*Time.deltaTime*rotationSpeed);
        
        // Vector3 movement = Vector3.zero;

        
        // movement += transform.forward * verticalInput * moveSpeed * Time.deltaTime;

        
        // movement += transform.right * horizontalInput * glideSpeed * Time.deltaTime;

        
        
    }
}

