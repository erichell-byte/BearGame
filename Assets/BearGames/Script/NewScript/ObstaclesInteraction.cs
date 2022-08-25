using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesInteraction : MonoBehaviour
{
    [SerializeField] private float _smallForce;
    [SerializeField] private float _medForce;
    [SerializeField] private float _hightForce;

    [SerializeField] private GameObject _restartButton;

    private Rigidbody _rb;
    

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        Time.timeScale = 1;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bugor"))
        {
            _rb.AddForce(Vector3.up * _smallForce, ForceMode.Impulse);
        }
        if (other.gameObject.CompareTag("Tramplin"))
        {
            _rb.AddForce(Vector3.up * _medForce, ForceMode.Impulse);
        }
        if (other.gameObject.CompareTag("Lyzha"))
        {
            if (_rb.velocity.z > _smallForce)
                _rb.AddForce(Vector3.back * _smallForce, ForceMode.VelocityChange);
        }
        if (other.gameObject.CompareTag("YamaGryaz"))
        {
            if (_rb.velocity.z > _medForce)
                _rb.AddForce(Vector3.back * _medForce, ForceMode.VelocityChange);
        }
        if (other.gameObject.CompareTag("Smert"))
        {
            _restartButton.SetActive(true);
            Time.timeScale = 0;
            
        }
    }
}
