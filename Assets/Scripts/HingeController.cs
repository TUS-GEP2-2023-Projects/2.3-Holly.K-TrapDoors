using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class HingeController : MonoBehaviour
{
    private HingeJoint2D hinge;

  // Start is called before the first frame update
  void Start()
    {
      hinge = GetComponent<HingeJoint2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void hingeSpeed(float SpeedToSet)
    {
        JointMotor2D theMotor = hinge.motor;
        theMotor.motorSpeed = speedToSet;
        hinge.motor = theMotor;
    }
}
