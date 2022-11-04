using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class KeyBoardInput : MonoBehaviour
{
    [SerializeField] private TransformMovement _movement;

    private void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        _movement.Move(new Vector3(-vertical, 0, 0));
    }
}
