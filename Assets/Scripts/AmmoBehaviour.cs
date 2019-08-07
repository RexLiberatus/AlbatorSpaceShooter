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
            UIvalues.Score += UIvalues.KillPoints;
            if(UIvalues.Score%250==0)
            { UIvalues.Lives += 1; }
            Destroy(collision.gameObject);
        }
    }
    IEnumerator Delay5sec()
    {
        Debug.Log(Time.time);
        yield return new WaitForSeconds(5f);
        Debug.Log(Time.time);
        Reset();
    }
    private void Reset()
    {
        gameObject.SetActive(false);
        gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        gameObject.transform.position = Vector3.zero;
        gameObject.transform.rotation = Quaternion.identity;
    }
}
