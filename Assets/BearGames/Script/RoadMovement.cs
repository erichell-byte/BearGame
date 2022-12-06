using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.EventSystems;
using Vector3 = UnityEngine.Vector3;

public class RoadMovement : MonoBehaviour
{
    [SerializeField] private Vector3 _minSpeed;
    [SerializeField] private Vector3 _maxSpeed;
    [SerializeField] public Vector3 _speed;

    [SerializeField] private Game _game;
    [SerializeField] private Animator _animator;
    
    
    private bool _boosted;
    private bool stoped;

    public Transform roadTransfrom;
    
    public void Update()
    {
        if (!stoped)
            roadTransfrom.position += _speed * Time.deltaTime;
        if (_boosted && !stoped)
            _speed = Vector3.Lerp(_speed, _maxSpeed, Time.deltaTime);
        else
            _speed = Vector3.Lerp(_speed, _minSpeed, Time.deltaTime);
        if (stoped)
            _speed = Vector3.Lerp(_speed, Vector3.zero, Time.deltaTime * 10);
    }

    public void UnderBoost()
    {
        _boosted = true;
        _animator.SetBool("isBoosted", true);
    }
    public void AfterBoost()
    {
        _boosted = false;
        _animator.SetBool("isBoosted", false);
    }

    public void ChangeForce(Vector3 newForce)
    {
        _speed += newForce;
    }

    public void StopCar()
    {
        stoped = true;
        _game.OnPlayerDied();
    }
}
