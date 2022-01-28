using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TeleportedRight : Teleport
{
    public float teleportLenght;

    public override void SetTransorm()
    {
        transform.position += new Vector3(teleportLenght, 0, 0);
    }
    
}
