using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDetector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out ObstacleInteractionRoad _obstacleInteraction))
        {
            _obstacleInteraction.InteractionWithRoad(GetComponent<RoadMovement>());
        }
        else if (other.TryGetComponent(out ObstacleInteractionCar _obstacleInteractionCar))
        {
            _obstacleInteractionCar.InteractionWithCar(GetComponent<CarThrow>());
        }
    }
}
