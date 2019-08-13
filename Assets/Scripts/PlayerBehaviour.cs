using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerBehaviour : MonoBehaviour
{
    private bool godmode;
    public int godModeDelay;

    private void Start()
    {
        gameObject.SetActive(true);
        godmode = false;
    }
    private void Update()
    {
        if (UIvalues.Lives < 0)
        {
            SceneManager.LoadScene(sceneBuildIndex: 2);
            gameObject.SetActive(false);
        }
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
