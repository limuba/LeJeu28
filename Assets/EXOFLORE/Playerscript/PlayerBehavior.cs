using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehavior : MonoBehaviour
{
    private Jump jump;
    private Move move;
    private TeleportR teleportr;
    private TeleportL teleportl;

    private float direction;
    private Rigidbody2D rigidbody2D;
    //private Vector2 lastFancingDirection;



    private void Awake()
    {
        
        jump = GetComponent<Jump>();
        move = GetComponent<Move>();
        teleportr = GetComponent<TeleportR>();
        teleportl = GetComponent<TeleportL>();

        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    
    public void TeleportRight(InputAction.CallbackContext obj)
    {
        if (!obj.performed) return;
        teleportr.SetTransformR();
    }

    
    public void TeleportLeft(InputAction.CallbackContext obj)
    {
        if (!obj.performed) return;
        teleportl.SetTransformL();
    }
    

    public void OnMove(InputAction.CallbackContext obj)
    {
        var value = obj.ReadValue<float>();
        direction = value;
        if (!obj.performed) return;
        //lastFancingDirection = value;
    }

    public void OnJump(InputAction.CallbackContext obj)
    {
        //Debug.Log("touch");
        jump.Jumper();
        if (!obj.performed) return;
        

    }

    private void Update()
    {
        //animations.SetSpeed(rigidbody2D.velocity.sqrMagnitude);
    }

    private void FixedUpdate()
    {
        move.Moving(direction);

    }

}
