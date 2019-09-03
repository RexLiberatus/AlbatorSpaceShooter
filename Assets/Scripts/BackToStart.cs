using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToStart : MonoBehaviour
{
    private float timerRestart;
    private void Awake()
    {
        timerRestart = 10f;
        FindObjectOfType<BackToStart>().enabled = true ;
    }
   
    private void FixedUpdate()
    {
        if (Input.GetButtonDown("Fire1") && SceneManager.GetActiveScene().buildIndex==2)
        {
            SceneManager.LoadScene(0);
            FindObjectOfType<BackToStart>().enabled = false;
        }
    }


}
