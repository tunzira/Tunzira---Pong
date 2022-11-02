using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedalContorller : MonoBehaviour
{
    public int speed;
    public KeyCode upkey;
    public KeyCode downkey;

    private Rigidbody2D rig;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        MoveObject(GetInput());
    }

    private Vector2 GetInput()
    {
        if (Input.GetKey(upkey))
        {
            return Vector2.up *  speed;
        }
        else if (Input.GetKey(downkey))
        {
            return Vector2.down * speed;
        }
        return Vector2.zero;
    }
    private void MoveObject(Vector2 movement) 
    {
        Debug.Log("TEST: " + movement);
        rig.velocity = movement;
    }
}
