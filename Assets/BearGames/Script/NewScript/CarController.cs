using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    private float _horizontalInput;
    private float _verticalInput;  
    private Vector3 _direction;
    private Rigidbody _rb;
    [SerializeField]
    private float _force; 
    
    [SerializeField]
    private float _maxForce;
    
    
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");
        _direction = new Vector3(-_verticalInput,0, _horizontalInput);
        Debug.Log(_rb.velocity);
        if (_rb.velocity.z <= _maxForce)
            _rb.AddForce(_direction * _force * Time.deltaTime, ForceMode.VelocityChange);
        
            
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
