using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceJump : Jump
{
    public float jumpForce;
    private bool canJump = false;
    public override void Jumper()
    {
        if (canJump)
        {
            rigidbody2D.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            canJump = false;
            Debug.Log("try");
        }
    }
    
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
    
}
