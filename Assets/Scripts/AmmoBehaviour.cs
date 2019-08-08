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
        ResetBullet();
        if(collision.gameObject.tag=="Mob")
        {
            UIvalues.Score += 25;
            Destroy(collision.gameObject);
        }
    }
    IEnumerator Delay5sec()
    {
        Debug.Log(Time.time);
        yield return new WaitForSeconds(3f);
        Debug.Log(Time.time);
        ResetBullet();
    }
    private void ResetBullet()
    {
        gameObject.SetActive(false);
        gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        gameObject.transform.position = Vector3.zero;
    }
}
