using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDetector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out ObstacleInteraction _obstacleInteraction))
        {
            _obstacleInteraction.Interaction(GetComponent<TransformMovement>());
        }
    }
}
