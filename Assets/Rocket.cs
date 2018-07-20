using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {

    Rigidbody rigidBody;
    AudioSource audioSource;
    // Use this for initialization
    void Start () {
        rigidBody = GetComponent<Rigidbody>(); //only act on conponent rigidbody(C# generics)
        audioSource = GetComponent<AudioSource>(); //only act on conponent rigidbody(C# generics)

    }

    // Update is called once per frame
    void Update () {
        Thrust();
        Rotate();
	}

    private void Rotate()
    {
        rigidBody.freezeRotation = true;
        
        if (Input.GetKey(KeyCode.A)) //turn left
        {
            transform.Rotate(Vector3.forward);
        }
        else if (Input.GetKey(KeyCode.D)) //turn left
        {
            transform.Rotate(-Vector3.forward);
        }
        rigidBody.freezeRotation = false;

    }
    private void Thrust()
    {
        if (Input.GetKey(KeyCode.W))  //thrust
        {
            rigidBody.AddRelativeForce(Vector3.up);
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        else
        {
            audioSource.Stop();
        }
    }
}
