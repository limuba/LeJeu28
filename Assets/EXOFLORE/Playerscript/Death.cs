using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    //private Rigidbody2D rigidbody2D;
    
    [SerializeField] private Transform Spawnpoint;
    public Rigidbody2D rigidbody2D;
    void start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    public void OnTriggerEnter2D (Collider2D colliderTriggered)
    {
        rigidbody2D.transform.position = Spawnpoint.position;
        Debug.Log("trig");
    }

}
