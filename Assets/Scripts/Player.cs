using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float maxSpeed;
    [SerializeField] private float jumpForce;

    private float direction;

    private Controls controls;

    private Rigidbody2D rigidbody2D;

    private SpriteRenderer spriteRenderer;

    private Animator animator;

    private bool canJump = false;

    private void OnEnable()
    {
        controls = new Controls();
        controls.Enable();
        controls.MoveJump.Jump.performed += JumpOnperformed;
        controls.MoveJump.MoveLR.performed += MoveLROnperformed;
        controls.MoveJump.MoveLR.canceled += MoveLROncanceled;

    }

    private void MoveLROncanceled(InputAction.CallbackContext obj)
    {
        direction = 0;
    }

    private void MoveLROnperformed(InputAction.CallbackContext obj)
    {
        direction = obj.ReadValue<float>();

        spriteRenderer.flipX = direction < 0;
    }

    private void JumpOnperformed(InputAction.CallbackContext obj)
    {
        if (canJump)
        {
            rigidbody2D.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            canJump = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        var hit = Physics2D.Raycast(transform.position, new Vector2(0, -1), 0.001f);

        if (hit.collider != null)
        {
            canJump = true;
        }
        else
        {
            canJump = false;
        }  
    }

    private void FixedUpdate()
    {
        var Speed = Mathf.Abs(rigidbody2D.velocity.x);
        if (Math.Abs(rigidbody2D.velocity.x) < maxSpeed)
        {
            rigidbody2D.AddForce(new Vector2(speed * direction, 0));
            animator.SetFloat("Speed", Speed);
        }
    }

}