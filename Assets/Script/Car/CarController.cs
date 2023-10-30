using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public Transform body;
    public float speedCar = 20;
    public float maxSpeed = 60;
    public float drag = .98f;
    public float turnSpeed = 120;
    public float traction = 1;
    public float bodyTilt = 30;

    public Vector3 moveForce;

    public void Update()
    {
        float y = Input.GetAxis("Vertical");
        float x = Input.GetAxis("Horizontal");
        moveForce += transform.forward * (speedCar * Time.deltaTime * y);
        transform.position += moveForce * Time.deltaTime;

        transform.Rotate(transform.up * (x * Time.deltaTime * turnSpeed * moveForce.magnitude));


        moveForce *= drag;
        moveForce = Vector3.ClampMagnitude(moveForce, maxSpeed);
        
        Debug.DrawRay(transform.position, transform.forward * 3, Color.blue);
        Debug.DrawRay(transform.position, moveForce.normalized * 3, Color.red);
        moveForce = Vector3.Lerp(moveForce.normalized, transform.forward, traction * Time.deltaTime) * moveForce.magnitude;

        float roll = Mathf.Lerp(0, bodyTilt, Mathf.Abs(x)) * Mathf.Sign(x);
        body.localRotation = Quaternion.Euler(Vector3.forward * (roll * moveForce.magnitude)) ;

    }
}
