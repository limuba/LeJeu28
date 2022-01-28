using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportedLeft : Teleport 
{ 
    public float teleportLenght;
    public override void SetTransorm()
    {
        transform.position += new Vector3(-teleportLenght, 0, 0);

    }
}
