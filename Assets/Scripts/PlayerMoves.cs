using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoves : MonoBehaviour
{
    private Rigidbody2D rb;


    public float speed;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {

        if (Input.GetAxis("Vertical") > 0)
        {
            MoveVert(Vector3.up);
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            MoveVert(Vector3.down);
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            MoveHor(Vector3.right);
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
        MoveHor(Vector3.left);
        }
        if(Input.GetKeyUp(KeyCode.Z) ||Input.GetKeyUp(KeyCode.S))
            { rb.velocity = Vector2.zero; }

        if (Input.GetKeyUp(KeyCode.Q) || Input.GetKeyUp(KeyCode.D))
            { rb.velocity = Vector2.zero; }


    }

    private void MoveHor(Vector3 horiz)
    {
        rb.velocity = (Vector2)horiz * speed;
    }

    private void MoveVert(Vector3 vert)
    {
        rb.velocity=(Vector2)vert*speed;
    }
}