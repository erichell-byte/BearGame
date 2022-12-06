using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public float distanceToCheck = 0.5f;
    public bool isGrounded;
    public LayerMask layerMask;

    [SerializeField] Animator _animator;

    public void Update()
    {
        if (Physics.Raycast(transform.position, Vector3.down, distanceToCheck,layerMask ))
        {
            isGrounded = true;
            _animator.SetBool("isTrampoline", false);
        }
        else
        {
            isGrounded = false;
            _animator.SetBool("isTrampoline", true);
        }
    }
}
