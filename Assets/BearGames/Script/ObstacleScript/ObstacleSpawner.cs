using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] obstacles;
    [SerializeField] private float upBorder;
    [SerializeField] private float downBorder;
    [SerializeField] private GameObject movementObject;
    
    
    private void Start()
    {
        InvokeRepeating(nameof(SpawnObstacle), Random.Range(1,2), Random.Range(1,2.5f));
    }

    private Vector3 GenerateRandomPosition()
    {
        return  new Vector3(Random.Range(upBorder, downBorder), 1, 110);
    }
    
    private void SpawnObstacle()
    {
        var randomIndex = Random.Range(0, obstacles.Length);
        var newObstacle = Instantiate(obstacles[randomIndex], GenerateRandomPosition(), obstacles[randomIndex].transform.rotation);
        newObstacle.transform.parent = movementObject.transform;
    }
}
