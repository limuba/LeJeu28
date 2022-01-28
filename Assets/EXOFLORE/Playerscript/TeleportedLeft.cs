using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportedLeft : TeleportL
{
    public float teleportLenght;

    public override void SetTransformL()
    {
        transform.position += new Vector3(teleportLenght, 0, 0);

    }
}
