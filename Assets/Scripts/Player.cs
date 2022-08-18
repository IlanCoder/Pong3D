using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Warcos was heeee - heeee
[DisallowMultipleComponent]
[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    [SerializeField, Min(0.1F)] float _speed;
    Rigidbody _rb;
    Vector3 _movement;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        _movement = vertical * transform.forward + horizontal * transform.right;
    }

    private void FixedUpdate()
    {
        _movement *= _speed * Time.fixedDeltaTime;
        _movement.y = _rb.velocity.y;
        _rb.velocity = _movement;
    }
}
