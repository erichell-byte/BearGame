using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    private float _horizontalInput;
    private float _verticalInput;
    private Vector2 _direction;
    [SerializeField]
    private float _speed;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");
        _direction = new Vector2(_horizontalInput, _verticalInput);
        transform.Translate(_direction * Time.deltaTime * _speed);
    }
}
