using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.EventSystems;
using Vector3 = UnityEngine.Vector3;

public class TransformMovement : MonoBehaviour
{
    [SerializeField] private Vector3 _minForce;
    [SerializeField] private Vector3 _maxForce;
    [SerializeField] private Vector3 _force;
    [SerializeField] private int _onSideMoveForce;
    private bool _boosted;
    private bool stoped;
    
    public Transform selfTransform;
    
    public void Move(Vector3 direction)
    {
        selfTransform.position += direction * (_onSideMoveForce * Time.deltaTime);
    }
    
    public void Update()
    {
        if (!stoped)
            selfTransform.position += _force * Time.deltaTime;
        if (_boosted && !stoped)
            _force = Vector3.Lerp(_force, _maxForce, Time.deltaTime);
        else
            _force = Vector3.Lerp(_force, _minForce, Time.deltaTime);
        if (stoped)
            _force = Vector3.Lerp(_force, Vector3.zero, Time.deltaTime * 10);
    }

    public void UnderBoost()
    {
        _boosted = true;
    }
    public void AfterBoost()
    {
        _boosted = false;
    }

    public void ChangeForce(Vector3 newForce)
    {
        _force += newForce;
    }

    public void StopCar()
    {
        stoped = true;
    }
    
    
    
}
