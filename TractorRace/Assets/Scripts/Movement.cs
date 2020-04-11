using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public WheelCollider WheelBL;
    public WheelCollider WheelBR;
    public WheelCollider WheelFR;
    public WheelCollider WheelFL;

    public Transform Wheel1;
    public Transform Wheel2;



    public int desA = 80;

    public float Velocity;
    public int VelMax = 200;
    public int Aceleration = 100;
    // Start is called before the first frame update
    void Start()
    {
     transform.GetComponent<Rigidbody>().centerOfMass = new Vector3 (0,-1f,0);   
    }

    void Update() {
        Wheel1.localEulerAngles = new Vector3 (0,WheelBL.steerAngle,0);
        Wheel2.localEulerAngles = new Vector3 (0,WheelBR.steerAngle,0);

        Wheel1.Rotate (new Vector3 (WheelBL.rpm / 200 * 360 * Time.deltaTime, 0 ,0));
        Wheel2.Rotate (new Vector3 (WheelBR.rpm / 200 * 360 * Time.deltaTime, 0 ,0));

        Velocity = (2 * Mathf.PI * WheelFR.radius) * WheelFR.rpm * 60 / 1000;
        Velocity = Mathf.Round (Velocity);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Mathf.Abs(Velocity) < VelMax){
        WheelFL.motorTorque = Aceleration * Input.GetAxis("Vertical");
        WheelFR.motorTorque = Aceleration * Input.GetAxis("Vertical");
        }else
        {
        WheelFL.motorTorque = 0;
        WheelFR.motorTorque = 0;
        }

        if (Input.GetAxis("Vertical") == 0){
            WheelFL.brakeTorque = desA;
            WheelFR.brakeTorque = desA;
        }else
        {
            WheelFL.brakeTorque = 0;
            WheelFR.brakeTorque = 0;
        }

        WheelBL.steerAngle = 10 * Input.GetAxis("Horizontal");
        WheelBR.steerAngle = 10 * Input.GetAxis("Horizontal");
    }
  
}
