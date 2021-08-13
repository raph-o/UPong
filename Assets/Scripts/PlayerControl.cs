using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [Header("Control")]
    public KeyCode ControlUp;
    public KeyCode ControlDown;

    private Rigidbody2D _rigibody;
    private Collider2D _collider;
    private float speed = 10f;
    private float borderOffset = 4.2f;

    // Start is called before the first frame update
    void Start ()
    {
        _rigibody = GetComponent<Rigidbody2D>();
        _collider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void FixedUpdate ()
    {
        var vel = _rigibody.velocity;
        var pos = _rigibody.position;

        PerformMovement(vel, pos);
    }

    void PerformMovement (Vector2 velocity, Vector2 position)
    {
        if (Input.GetKey(ControlUp)) velocity.y = speed;
        else if (Input.GetKey(ControlDown)) velocity.y = -speed;
        else velocity.y = 0;

        _rigibody.velocity = velocity;

        if (position.y > borderOffset) position.y = borderOffset;
        else if (position.y < -borderOffset) position.y = -borderOffset;

        transform.position = position;
    }
}
