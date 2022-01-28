using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Mover2D : MonoBehaviour
{
    protected new Rigidbody2D rigidbody2D;

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public abstract void Move(float direction);
}
