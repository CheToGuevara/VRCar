using UnityEngine;
using System.Collections;

public class Car : MonoBehaviour {

    public float power = 3;
    public float maxspeed = 5;
    public float turnpower = 2;
    public float friction = 3;
    public Vector3 curspeed;
    Rigidbody myrigidbody;

    private bool stopped=false;

    public bool Stopped
    {
        get
        {
            return stopped;
        }
        set
        {
            stopped = true;
        }
    }

    // Use this for initialization
    void Start()
    {
        stopped = false;
        myrigidbody = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {

        if (stopped)
        {
            myrigidbody.velocity = new Vector3(0, 0, 0);
            return;
        }
        
        curspeed = myrigidbody.velocity;

        if (curspeed.magnitude > maxspeed)
        {
            curspeed = curspeed.normalized;
            curspeed *= maxspeed;
        }

        float pedal = Input.GetAxis("Vertical");

        if (pedal > 0)
        {
            myrigidbody.AddForce(transform.forward * power);
            myrigidbody.drag = friction;
        }
        if (pedal < 0)
        {
            if (curspeed.z > 0.001)
                myrigidbody.AddForce(0,0,-curspeed.z);
            myrigidbody.drag = friction*3;
        }
        

        noGas();

    }

    void noGas()
    {
        bool gas;
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            gas = true;
        }
        else
        {
            gas = false;
        }

        if (!gas)
        {
            myrigidbody.drag = friction ;
        }
    }

    
}
