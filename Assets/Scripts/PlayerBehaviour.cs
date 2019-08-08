using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
   private bool godmode;
    public int godModeDelay;

    private void Start()
    {
        godmode = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Mob")
        {
            UIvalues.Lives -= 1;
            godmode = true;
            Destroy(collision.gameObject);
            StartCoroutine(UnableGodMode(godModeDelay));
           
        }
    }

    IEnumerator UnableGodMode(int delay)
    {
        yield return new WaitForSeconds(delay);
        godmode = false;
    }
}
