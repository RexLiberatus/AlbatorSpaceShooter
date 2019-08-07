using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobBehaviour : MonoBehaviour
{
    [SerializeField]
    private float speed;

    public float Speed { get => speed; set => speed = value; }

    private void Start()
    {
        Move();
    }
    public void Move()
    {
        var rb = GetComponent<Rigidbody2D>();
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
}
