using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToStart : MonoBehaviour
{
   
    private void FixedUpdate()
    {
        if (Input.GetButtonDown("Fire1") && SceneManager.GetActiveScene().buildIndex==2)
        {
            UIvalues.HighScore = UIvalues.Score;
            UIvalues.Score = 0;
            SceneManager.LoadScene(0);
        }
    }


}
