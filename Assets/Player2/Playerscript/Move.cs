using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private new Rigidbody2D rigidbody2D;
    public float acceleration;
    public float maxSpeed;

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void Moving(float direction)
    {
        if (rigidbody2D.velocity.sqrMagnitude < maxSpeed)
            rigidbody2D.AddForce (new Vector2(direction * acceleration,0));
    }

}
