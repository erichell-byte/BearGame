using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField]
    private ObstacleObject _obstacleObj;


    public ObstacleObject ObstacleObj
    {
        get 
        {
            return _obstacleObj;
        }
    }
    
}
