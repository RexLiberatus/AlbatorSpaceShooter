using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBehaviour : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(Delay5sec());
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("aïe");
        Reset();
        if(collision.gameObject.tag=="Mob")
        {
            //increase score here
            //then
            Destroy(collision.gameObject);
        }
    }
    IEnumerator Delay5sec()
    {
        Debug.Log(Time.time);
        yield return new WaitForSeconds(3f);
        Debug.Log(Time.time);
        Reset();
    }
    private void Reset()
    {
        gameObject.SetActive(false);
        gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        gameObject.transform.position = Vector3.zero;
    }
}
