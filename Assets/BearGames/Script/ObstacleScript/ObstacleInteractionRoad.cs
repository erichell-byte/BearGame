using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleInteractionRoad : MonoBehaviour
{
    public virtual void InteractionWithRoad(RoadMovement roadMovement)
    {
        Debug.Log("Obstacle has touching");
    }
}
