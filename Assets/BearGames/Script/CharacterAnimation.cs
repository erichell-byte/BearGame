using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    /*
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Trampoline(Clone)")
        {
            _animator.SetBool("isTrampoline", true);
            //_animator.Play("Trampoline");
            Debug.Log("бньек");
        }
        
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Trampoline(Clone)")
        {
            //_animator.SetBool("isTrampoline", false);
            Debug.Log("бшьек");
            //_animator.Play("Riding");
        }
    }
    */
}
