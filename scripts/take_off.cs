using UnityEngine;

public class PlaneTakeoffController : MonoBehaviour
{
    public float takeoffSpeed = 5.0f; // Speed at which the plane takes off
    public float takeoffHeight = 10.0f; // Height at which the plane levels off

    private bool isTakingOff = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isTakingOff)
        {
            StartTakeoff();
        }

        if (isTakingOff)
        {
            Takeoff();
        }
    }

    private void StartTakeoff()
    {
        isTakingOff = true;
    }

    private void Takeoff()
    {
        // Move the plane up along the Y-axis
        transform.Translate(Vector3.up * takeoffSpeed * Time.deltaTime);

        // Check if the plane has reached the desired height
        if (transform.position.y >= takeoffHeight)
        {
            isTakingOff = false;
            // Plane has leveled off, you can perform other actions here if needed.
        }
    }
}
