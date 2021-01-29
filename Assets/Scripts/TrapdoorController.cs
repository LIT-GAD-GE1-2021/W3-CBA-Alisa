using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapdoorController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private HingeJoint2D trapDoor;
    public int speedOpen = 10;
    public int speedClose = -10;

    public void Open()
    {
        JointMotor2D theMotor = trapDoor.motor;
        theMotor.motorSpeed = speedOpen;
        trapDoor.motor = theMotor;
    }

    public void Close()
    {
        JointMotor2D theMotor = trapDoor.motor;
        theMotor.motorSpeed = speedClose;
        trapDoor.motor = theMotor;
    }
}
