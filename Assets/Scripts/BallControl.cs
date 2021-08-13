using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    private Rigidbody2D _rigidbody;

    // Start is called before the first frame update
    void Start ()
    {
        _rigidbody = GetComponent<Rigidbody2D>();

        Invoke("StartBall", 3);
    }

    void ResetBall ()
    {
        _rigidbody.velocity = new Vector2(0, 0);
        transform.position = new Vector2(0, 0);

        Invoke("StartBall", 3);
    }

    void StartBall ()
    {
        float rand = Random.Range(0, 2);

        if (rand < 1) _rigidbody.AddForce(Vector2.left, ForceMode2D.Impulse);
        else _rigidbody.AddForce(Vector2.right, ForceMode2D.Impulse);
    }

    void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Vector2 vel;

            vel.x = _rigidbody.velocity.x;
            vel.y = (_rigidbody.velocity.y / 2) + (collision.collider.attachedRigidbody.velocity.y / 3);
            _rigidbody.velocity = vel;
        }
    }
}
