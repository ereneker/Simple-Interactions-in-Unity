using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    public float turnSpeed = 4.0f;
    public float moveSpeed = 2.0f;
 
    public float minTurnAngle = -90.0f;
    public float maxTurnAngle = 90.0f;
    private float rotX;
    private float roty;
 
    void Update ()
    {
        MouseAiming();
    }
 
    void MouseAiming ()
    {

        roty = Input.GetAxis("Mouse X") * turnSpeed;
        rotX += Input.GetAxis("Mouse Y") * turnSpeed;
   
        transform.eulerAngles = new Vector3(-rotX, transform.eulerAngles.y + roty, 0);
    }
 
}
