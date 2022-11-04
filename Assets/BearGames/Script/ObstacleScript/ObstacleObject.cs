using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Obstacle", menuName = "Obstacle/New obstacle")]
public class ObstacleObject : ScriptableObject
{
    [SerializeField]
    private Vector2 _obstacleSize;
    [SerializeField]
    private Sprite _obstacleImage;
    [SerializeField]
    private ObstacleType _type;
    [SerializeField]
    private Vector2 _directionOfAction;
    [SerializeField]
    private bool _isKilling;

    public Vector2 ObstacleSize
    {
        get
        {
            return _obstacleSize;
        }
    }

    public Sprite ObstacleImage
    {
        get
        {
            return _obstacleImage;
        }
    }

    public ObstacleType ObstacleType
    {
        get
        {
            return _type;
        }
    }

    public Vector2 DirectionOfAction
    {
        get
        {
            return _directionOfAction;
        }
    }

    public bool IsKilling
    {
        get
        {
            return _isKilling;
        }
    }

    public void Interaction()
    {
        Debug.Log("helios");
    }
}
