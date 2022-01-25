using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    [SerializeField] private Transform Spawnpoint;
    private void CheckForDeath (Collider2D colliderTriggered)
    {
        rigidbody2D.transform.position = Spawnpoint.position;
    }
}
