using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    private RoadMovement _roadMovement;

    private void Start()
    {
        _roadMovement = GameObject.Find("MedvedCar").GetComponent<RoadMovement>();
    }

    private void Update()
    {
        transform.position += _roadMovement._speed * Time.deltaTime;
    }
}
