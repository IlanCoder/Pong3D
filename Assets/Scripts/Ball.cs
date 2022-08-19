using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof(Rigidbody))]
public class Ball : MonoBehaviour
{
    [SerializeField] float _speed;
    Rigidbody _rb;
    //HOLI RAVIOLI
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
 
    void Update()
    {
        
    }

    void FixedUpdate() {
        _rb.velocity = _speed * Time.fixedDeltaTime * Vector3.right;
    }

}
