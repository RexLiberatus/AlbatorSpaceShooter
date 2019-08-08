using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobBehaviour : MonoBehaviour
{
    [SerializeField]
    private float speed;

    Rigidbody2D rb;
    public float Speed { get => speed; set => speed = value; }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Move();
    }
    public void Move()
    {
       
        var camPosition = Camera.main.transform.position;
        if( camPosition.y >= transform.position.y)
        {
            rb.AddRelativeForce(Vector2.up * speed, ForceMode2D.Impulse);
        }
        else
        {
            rb.AddRelativeForce(Vector2.down * speed, ForceMode2D.Impulse);
        }
    }
    private void Update()
    {
        if (Camera.main.WorldToViewportPoint(transform.position).y >=2) 
        rb.velocity = -rb.velocity;
        if (Camera.main.WorldToViewportPoint(transform.position).y <= -1)
            rb.velocity = -rb.velocity;
    }
}
