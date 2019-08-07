using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimiterLeft : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        DeleteMobs(collision);
        BlockPlayer(collision);
    }

    private static void BlockPlayer(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.transform.position = collision.gameObject.transform.position;
        }
    }

    private static void DeleteMobs(Collider2D collision)
    {
        if (collision.gameObject.tag == "Mob")
        {
            Destroy(collision.gameObject);
        }
    }
}
