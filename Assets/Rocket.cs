using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {

    Rigidbody rigidBody;
	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody>(); //only act on conponent rigidbody(C# generics)
	}
	
	// Update is called once per frame
	void Update () {
        ProcessInput();
	}

    private void ProcessInput()
    {
        if (Input.GetKey(KeyCode.Space))  //thrust
        {
            rigidBody.AddRelativeForce(Vector3.up);
            //print("thrust");
        }
        if (Input.GetKey(KeyCode.A)) //turn left
        {
            transform.Rotate(Vector3.forward);
        }
        else if (Input.GetKey(KeyCode.D)) //turn left
        {
            transform.Rotate(-Vector3.forward);


            //test2
        }
    }
}
