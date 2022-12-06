using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TrampolineInteraction : ObstacleInteractionCar
{
    [SerializeField]
    private ObstacleObject _obstacleObj;

    public override void InteractionWithCar(CarThrow carThrow)
    {
        carThrow.ImpactOnCar(_obstacleObj.DirectionOfAction, _obstacleObj.Force);
    }
}
