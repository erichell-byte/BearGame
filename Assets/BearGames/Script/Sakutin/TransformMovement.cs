using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TransformMovement : MonoBehaviour
{
    [SerializeField] private Vector3 _minForce;
    [SerializeField] private Vector3 _maxForce;
    [SerializeField] private Vector3 _force;
    [SerializeField] private int _onSideMoveForce;
    private bool _boosted;
    
    public Transform selfTransform;
    
    public void Move(Vector3 direction)
    {
        selfTransform.position += direction * (_onSideMoveForce * Time.deltaTime);
    }
    
    public void Update()
    {
        selfTransform.position += _force * Time.deltaTime;
        if (_boosted)
            _force = Vector3.Lerp(_force, _maxForce, Time.deltaTime);
        else
            _force = Vector3.Lerp(_force, _minForce, Time.deltaTime);
    }

    public void UnderBoost()
    {
        _boosted = true;
    }
    public void AfterBoost()
    {
        _boosted = false;
    }
    
    
    
}
