using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : Mover2D
{
    public float acceleration;
    public float maxSpeed;
    public override void Move (float direction)
    {
        if (rigidbody2D.velocity.sqrMagnitude < maxSpeed)
            rigidbody2D.AddForce (new Vector2(direction * acceleration, 0));
    }
}
