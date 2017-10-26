using UnityEngine;

public class move : MonoBehaviour {
    
    private const float Y_ANGLE_MIN = -0.0f;
    private const float Y_ANGLE_MAX = 0.0f;

    public Rigidbody cube;
    public float force = 200;
    private float distance = 10.0f;
    private float currentX = 0.0f;
    private float currentY = 0.0f;
    private float sensivityX = 4.0f;
    private float sensivityY = 1.0f;
    private void FixedUpdate()
    {
        if (Input.GetKey("a"))
        {
            cube.AddRelativeForce(force, 0, 0);
           
        }
        if (Input.GetKey("w"))
        {
            cube.AddRelativeForce(0, 0, force);
            
        }
        if (Input.GetKey("d"))
        {
            cube.AddRelativeForce(-force, 0, 0);
        }
        if (Input.GetKey("s"))
        {
            cube.AddRelativeForce(0, 0, -force);
        }
    }

    private void Update()
    {
        currentX += Input.GetAxis("Mouse X");
        currentY += Input.GetAxis("Mouse Y");

        currentY = Mathf.Clamp(currentY, Y_ANGLE_MIN, Y_ANGLE_MAX);
    }

    private void LateUpdate()
    {
        Vector3 dir = new Vector3(0, 0, -distance);
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        transform.rotation = rotation;

    }
}
