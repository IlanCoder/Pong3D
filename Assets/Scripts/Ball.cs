using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

[DisallowMultipleComponent]
[RequireComponent(typeof(Rigidbody))]
public class Ball : MonoBehaviour
{
    [SerializeField] float _speed;
    [SerializeField] Transform _initPos;
    Vector3 _direction;
    Rigidbody _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _direction = Vector3.forward;
        _direction.Normalize();
        _rb.velocity = _direction * _speed;
    }

    void FixedUpdate() {
        _direction = _rb.velocity;
        _direction.Normalize();
        _direction *= _speed * Time.fixedDeltaTime;
        _direction.y = _rb.velocity.y;
        _rb.velocity = _direction;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Goal"))
        {
            transform.position = _initPos.position;
        }
    }
}
