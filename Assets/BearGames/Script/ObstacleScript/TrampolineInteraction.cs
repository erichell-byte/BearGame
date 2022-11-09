using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TrampolineInteraction : ObstacleInteraction
{
    [SerializeField]
    private ObstacleObject _obstacleObj;
    public override void Interaction(TransformMovement transformMovement)
    {
        transformMovement.ChangeForce(_obstacleObj.DirectionOfAction);
    }
}
