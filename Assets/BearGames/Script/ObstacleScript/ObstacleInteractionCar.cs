using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleInteractionCar : MonoBehaviour
{
    public virtual void InteractionWithCar(CarThrow transformMovement)
    {
        Debug.Log("Car was Impacted");
    }
}
