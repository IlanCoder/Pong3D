using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof(Rigidbody))]
public class Ball : MonoBehaviour
{
    [SerializeField] float _speed;
    Rigidbody _rb;
    Vector3 _direction;

    //HOLI RAVIOLI
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _direction = Vector3.forward;
    }

    private void Update()
    {
    }

    void FixedUpdate() {
        Vector3 dir = _direction * _speed * Time.fixedDeltaTime;
        dir.y = _rb.velocity.y;
        _rb.velocity = dir;
    }
}
