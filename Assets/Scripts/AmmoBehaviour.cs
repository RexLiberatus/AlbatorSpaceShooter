using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBehaviour : MonoBehaviour
{
    bool fired;
    public bool Fired { get => fired; set => fired = value; }

    private void Start()
    {
        StartCoroutine(Delay5sec());
        bool fired = false;
    }
    private void FixedUpdate()
    {
        if (fired)
        {
            StartCoroutine(Delay5sec());
        }
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
        yield return new WaitForSeconds(3f);
        ResetBullet();
        fired = false;
    }
    private void ResetBullet()
    {
        gameObject.SetActive(false);
        gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        gameObject.transform.position = Vector3.zero;
    }
}
