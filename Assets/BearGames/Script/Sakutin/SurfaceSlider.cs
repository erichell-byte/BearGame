using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurfaceSlider : MonoBehaviour
{
    private Vector3 _normal;
    public Vector3 Project(Vector3 direction)
    {
        return direction - Vector3.Dot(direction, _normal) * _normal;
    }

    private void OnCollisionEnter(Collision collision)
    {
        _normal = collision.contacts[0].normal;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + _normal * 3);
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(transform.position, transform.position + Project(transform.forward) * 3 );
    }
}
