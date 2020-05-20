using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpPower;

    private Rigidbody2D rb2D;
    private Animator animator;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        animator = GetComponent<Animator>();
        rb2D = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("Run", true);
            spriteRenderer.flipX = false;
            transform.Translate(_speed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("Run", true);
            spriteRenderer.flipX = true;
            transform.Translate(_speed * Time.deltaTime * -1, 0, 0);
        }
        else
        {
            animator.SetBool("Run", false);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb2D.AddForce(Vector2.up * _jumpPower);
        }
    }
}
