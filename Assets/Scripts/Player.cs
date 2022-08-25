using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Warcos was heeee - heeee
[DisallowMultipleComponent]
[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    [SerializeField, Min(0.1F)] float _speed;
    [SerializeField, Min(0.1F)] float _jumpForce;
    [SerializeField, Min(0.5F)] float _jumpCD;
    bool _jumping = false;
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
        if (Input.GetAxis("Jump") > 0)
        {
            Jump();
        }
    }

    private void FixedUpdate()
    {
        _movement *= _speed * Time.fixedDeltaTime;
        _movement.y = _rb.velocity.y;
        _rb.velocity = _movement;
    }

    void Jump()
    {
        if (_jumping) return;
        _rb.AddForce(_jumpForce * Vector3.up, ForceMode.VelocityChange);
        _jumping = true;
        StartCoroutine(WaitForJumpCD());
    }

    IEnumerator WaitForJumpCD()
    {
        yield return new WaitForSeconds(_jumpCD);
        _jumping = false;
    }
}
