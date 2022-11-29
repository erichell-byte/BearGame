using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuddleInteraction : ObstacleInteractionRoad
{
    [SerializeField]
    private ObstacleObject _obstacleObj;
    public override void InteractionWithRoad(RoadMovement roadMovement)
    {
        roadMovement.ChangeForce(_obstacleObj.DirectionOfAction);
    }
}
