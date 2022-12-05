using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostAnimator : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    public void PlayAnimation()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _animator.SetBool("isBoosted", true);
            _animator.Play("Boost");
        }
        if (Input.GetMouseButtonUp(0))
        {
            _animator.SetBool("isBoosted", false);
        }
    }

    //public void PointerDown()
    //{
    //    isTouched = true;
    //}

    //public void PointerUp()
    //{
    //    isTouched = false;
    //}

    //private void Update()
    //{
    //    if (isTouched == true)
    //    {
    //        _animator.Play("Boost");
    //    }
    //    else
    //    {
    //        isTouched = false;
    //    }
    //}
}
