using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirtInteraction : ObstacleInteraction
{
    [SerializeField]
    private ObstacleObject _obstacleObj;
    public override void Interaction(TransformMovement transformMovement)
    {
        transformMovement.ChangeForce(_obstacleObj.DirectionOfAction);
    }
}
