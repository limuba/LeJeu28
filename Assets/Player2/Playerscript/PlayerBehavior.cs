using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehavior : MonoBehaviour
{
    private Jump jump;
    private Move move;
    private Teleport teleport;

    private float direction;
    private new Rigidbody2D rigidbody2D;
    //private Vector2 lastFancingDirection
    private void Awake()
    {
        
        jump = GetComponent<Jump>();
        move = GetComponent<Move>();
        teleport = GetComponent<Teleport>();

        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    
    public void TeleportRight(InputAction.CallbackContext obj)
    {
        teleport.SetTransorm();
    }
    public void TeleportLeft(InputAction.CallbackContext obj)
    {
        teleport.SetTransorm();
    }
    public void OnMove(InputAction.CallbackContext obj)
    {
        var value = obj.ReadValue<float>();
        direction = value;
        if (!obj.performed) return;

        //animations.UpdateFacingDirection(value);
        //lastFacingDirection = value;
    }
    public void OnJump(InputAction.CallbackContext obj)
    {
        //Debug.Log("touch");
        if (!obj.performed) return;
        jump.Jumper();

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
