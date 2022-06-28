using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawGrip : MonoBehaviour
{
    [SerializeField] HingeJoint2D L;
    [SerializeField] HingeJoint2D R;
    [SerializeField] float speed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            JointMotor2D m = L.motor;
            m.motorSpeed = speed;
            L.motor = m;
            m = R.motor;
            m.motorSpeed = -speed;
            R.motor = m;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            JointMotor2D m = L.motor;
            m.motorSpeed = -speed;
            L.motor = m;
            m = R.motor;
            m.motorSpeed = speed;
            R.motor = m;
        }
    }
}
