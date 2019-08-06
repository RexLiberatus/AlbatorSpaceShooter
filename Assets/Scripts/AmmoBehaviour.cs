using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBehaviour : MonoBehaviour
{
    private void Start()
    {
        
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("aïe");
        gameObject.SetActive(false);
        gameObject.GetComponent<Rigidbody2D>().velocity=Vector2.zero;
        gameObject.transform.position = Vector3.zero;
    }
}
