using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatObject : MonoBehaviour
{
    public float _width;
    public Vector3 _startPos;

    private void Start()
    {
        _startPos = transform.position;
        _width = GetComponent<BoxCollider>().size.z/2;
    }

    private void Update()
    {
        if (transform.position.z < _startPos.z - _width)
        {
            transform.position = _startPos;
        }
    }
}
