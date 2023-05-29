using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float thrustSpeed = 5;
    [SerializeField] float rotationSpeed = 5;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }



    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }
    private void ProcessThrust()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.up * thrustSpeed * Time.deltaTime);
        }
    }
    private void ProcessRotation()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            ApplyRotation(-rotationSpeed);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            ApplyRotation(rotationSpeed);
        }
    }

    void ApplyRotation(float rotationThisFrame)
    {
        rb.freezeRotation = true;
        transform.Rotate(rotationThisFrame * Vector3.forward * Time.deltaTime);
        rb.freezeRotation = false;
    }
}
