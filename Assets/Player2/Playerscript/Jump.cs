using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public abstract class Jump : MonoBehaviour
{
    protected new Rigidbody2D rigidbody2D;
    

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    public abstract void Jumper();
}
