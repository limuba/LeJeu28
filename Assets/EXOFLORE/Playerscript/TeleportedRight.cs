using System.Collections.Generic;
using UnityEngine;

public class TeleportedRight : TeleportR
{
    public float teleportLenght;

    public override void SetTransformR()
    {
        transform.position += new Vector3(teleportLenght, 0, 0);
    }
    
}
