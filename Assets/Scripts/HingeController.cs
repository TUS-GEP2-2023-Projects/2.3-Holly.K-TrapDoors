using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class HingeController : MonoBehaviour
{
    private HingeJoint2D hinge;
    public Switch2 myScript;
    //public bool switchOn;

    // Start is called before the first frame update
    void Start()
    {
        hinge = GetComponent<HingeJoint2D>();
        var motor = hinge.motor;
        motor.motorSpeed = 0;
    }

    // Update is called once per frame
    void Update()
    {
            //hinge.motor = motor
        if (myScript.switchOn == true)
        {
            var motor = hinge.motor;
            motor.motorSpeed = 90;
            hinge.motor = motor;
        }
        //else if (switchOn == false)
       // {
        //    var motor = hinge.motor;
       //     motor.motorSpeed = -3;
      //  }
    }
}
