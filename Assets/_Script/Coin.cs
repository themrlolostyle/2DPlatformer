using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private BoxCollider2D boxCol2D;
    private Rigidbody2D rigidbody2D;

    private void OnEnable()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        boxCol2D = GetComponent<BoxCollider2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rigidbody2D.bodyType = RigidbodyType2D.Static;
        boxCol2D.isTrigger = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<Movement>(out Movement movement))
        {
            Destroy(gameObject);
        }
    }
}
