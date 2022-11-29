using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarThrow : MonoBehaviour
{
    
    private float velocity;
    private Vector3 moveDirection;
    public GroundCheck groundCheck;
    public float gravityScale = 1;
    public float gravity = -9.81f;
    
    
    public void ImpactOnCar(Vector3 effectDirection, float force)
    {
        velocity = force;
    }

    private void Update()
    {
        velocity += gravity * gravityScale * Time.deltaTime;
        if (groundCheck.isGrounded && velocity < 0)
            velocity = 0;
        transform.Translate(new Vector3(0, velocity, 0) * Time.deltaTime);
    }
}
