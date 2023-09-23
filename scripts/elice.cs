using UnityEngine;

public class RotatingObject : MonoBehaviour
{
    public float rotationSpeed = 4000.0f; 

    void Update()
    {
        
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}


