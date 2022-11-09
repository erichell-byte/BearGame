using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StumpInteraction : ObstacleInteraction
{
    [SerializeField]
    private ObstacleObject _obstacleObj;

    public override void Interaction(TransformMovement transformMovement)
    {
        transformMovement.StopCar();
    }
}
