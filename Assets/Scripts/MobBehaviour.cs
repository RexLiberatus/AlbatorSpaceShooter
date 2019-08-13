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
            rb.velocity=Vector2.up * speed;
        }
        else
        {
            transform.rotation = new Quaternion(0, 0, transform.rotation.z + 180f, 0);
            rb.velocity = Vector2.down * speed;
        }
    }
    private void Update()
    {
        if (Camera.main.WorldToViewportPoint(transform.position).y >= 2)
        {
            transform.rotation = new Quaternion(0, 0, transform.rotation.z + 180f,0);
            rb.velocity = -rb.velocity;
        }
        if (Camera.main.WorldToViewportPoint(transform.position).y <= -1)
        {
            transform.rotation = new Quaternion(0, 0, transform.rotation.z + 180f, 0);
            rb.velocity = -rb.velocity;
        }
    }
    IEnumerator Lifespan()
    {
        yield return new WaitForSeconds(30f);
        Destroy(gameObject);
    }
}
