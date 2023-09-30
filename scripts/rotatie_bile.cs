using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpObjects : MonoBehaviour
{
    public float jumpHeight = 1.0f; // Adjust the jump height as needed
    public float jumpSpeed = 1.0f;  // Adjust the jump speed as needed
    private Vector3 initialPosition;
    private bool movingUp = true;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        float newY;

        if (movingUp)
        {
            newY = initialPosition.y + jumpHeight;
        }
        else
        {
            newY = initialPosition.y;
        }

        transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, newY, transform.position.z), jumpSpeed * Time.deltaTime);

        if (transform.position.y >= initialPosition.y + jumpHeight)
        {
            movingUp = false;
        }
        else if (transform.position.y <= initialPosition.y)
        {
            movingUp = true;
        }
    }
}
