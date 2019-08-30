using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToStart : MonoBehaviour
{
   private float timerRestart;

    void Start()
    {
        
            timerRestart = 10f;
        StartCoroutine(EndScreenDelay(timerRestart));

        
    }

    IEnumerator EndScreenDelay(float endTime)
    {
        yield return new WaitForSeconds(endTime);
        SceneManager.LoadScene("01.StartMenu");
    }
    
}
