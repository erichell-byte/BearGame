using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderForCar : MonoBehaviour
{
    [SerializeField] private float topBorder;
    [SerializeField] private float downBorder;
    [SerializeField] private float leftBorder;
    [SerializeField] private float rightBorder;
    

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < leftBorder)
            transform.position = new Vector3(leftBorder, transform.position.y, transform.position.z);
        if (transform.position.x > rightBorder)
            transform.position = new Vector3(rightBorder, transform.position.y, transform.position.z);
        if (transform.position.y > topBorder)
            transform.position = new Vector3(transform.position.x, topBorder, transform.position.z);
        if (transform.position.y < downBorder)
            transform.position = new Vector3(transform.position.x, downBorder, transform.position.z);
        
    }
}
