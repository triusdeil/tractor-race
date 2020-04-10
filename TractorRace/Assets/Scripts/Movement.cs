using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public WheelCollider WheelBL;
    public WheelCollider WheelBR;
    public WheelCollider WheelFR;
    public WheelCollider WheelFL;
    public int Velocity = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        WheelFL.motorTorque = Velocity * Input.GetAxis("Vertical");
        WheelFR.motorTorque = Velocity * Input.GetAxis("Vertical");

        WheelBL.steerAngle = 10 * Input.GetAxis("Horizontal");
        WheelBR.steerAngle = 10 * Input.GetAxis("Horizontal");
    }
}
