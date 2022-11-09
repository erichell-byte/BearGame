using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleInteraction : MonoBehaviour
{
    public virtual void Interaction(TransformMovement transformMovement)
    {
        Debug.Log("Obstacle has touching");
    }
}
