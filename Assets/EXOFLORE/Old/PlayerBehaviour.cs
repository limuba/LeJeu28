using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehaviour : MonoBehaviour
{
    //public PlayerSpeedTunnel playerSpeed;

    private AddForce move;
    private float direction;
    private new Rigidbody2D rigidbody2D;
    private void Awake()
    {
        move = GetComponent<AddForce>();
  
       
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    public void OnMove(InputAction.CallbackContext obj)
    {
        var value = obj.ReadValue<float>();
        direction = value;
        if (!obj.performed) return;
    }
    private void FixedUpdate()
    {
        move.Move(direction);
    }

}
