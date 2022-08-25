using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    [SerializeField] private GameObject _obstaclePrefab;
    private float _spawnTime;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", 1, Random.Range(0,3));
    }

    void SpawnObstacle()
    {
        Instantiate(_obstaclePrefab, new Vector3(10, Random.Range(-3f, -1.5f), -1.71f), Quaternion.identity);
    }
}
