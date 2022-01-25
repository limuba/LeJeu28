using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehavior : MonoBehaviour
{
    private Move move;
    private float direction;
    private new Rigidbody2D rigidbody2D;

    private void Awake()
    {
        move = GetComponent<Move>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    public void OnMove(InputAction.CallbackContext obj)
    {
        var value = obj.ReadValue<float>();
        direction = value;
        if (!obj.performed) return;

        //animations.UpdateFacingDirection(value);
        //lastFacingDirection = value;
    }
    private void Update()
    {
        //animations.SetSpeed(rigidbody2D.velocity.sqrMagnitude);
        //playerSpeed.DisplaySpeed(rigidbody2D.velocity.magnitude);
    }

    private void FixedUpdate()
    {
        move.Moving(direction);

    }

    public void OnDamaged()
    {
        //ded
    }
}
