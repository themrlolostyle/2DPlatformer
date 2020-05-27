using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(SpriteRenderer))]
public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpPower;

    private Rigidbody2D _rb2D;
    private Animator _animator;
    private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _rb2D = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            Move(false);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Move(true);
        }
        else
        {
            _animator.SetBool("Run", false);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            _rb2D.AddForce(Vector2.up * _jumpPower);
        }
    }

    public void Move(bool leftDirection)
    {
        _animator.SetBool("Run", true);
        _spriteRenderer.flipX = leftDirection;

        if (leftDirection == true)
        {
            transform.Translate(_speed * Time.deltaTime * -1, 0, 0);
        }
        else
        {
            transform.Translate(_speed * Time.deltaTime, 0, 0);
        }
    }
}
