using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallHillInteraction : ObstacleInteractionCar
{
    [SerializeField]
    private ObstacleObject _obstacleObj;
    public override void InteractionWithCar(CarThrow transformMovement)
    {
        transformMovement.ImpactOnCar(_obstacleObj.DirectionOfAction, _obstacleObj.Force);
    }
}
