using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField] private int _onSideMoveForce;
    [SerializeField] private float upBorder = -22.5f;
    [SerializeField] private float downBorder = 24f;
    
    public void Move(Vector3 direction)
    {
        transform.position += direction * (_onSideMoveForce * Time.deltaTime);
    }

    public void Update()
    {
        var transformPosition = transform.position;
        if (transformPosition.x > downBorder)
            transformPosition.x = downBorder;
        else if (transformPosition.x < upBorder)
            transformPosition.x = upBorder;
        transform.position = transformPosition;
    }
}
