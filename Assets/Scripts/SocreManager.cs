using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SocreManager : MonoBehaviour
{
    public TMPro.TextMeshProUGUI playerScore;
    public TMPro.TextMeshProUGUI highScore;

    private void Start()
    {
        if (UIvalues.Score.ToString() != null)
            playerScore.text = UIvalues.Score.ToString();
        else
            playerScore.text = "0";

        RecordScore();
        CheckHighScores();
        if(GetComponent<BackToStart>()!=null)
        GetComponent<BackToStart>().enabled = true;
    }
    //write score in file
    public static void RecordScore()
    {
        FindObjectOfType<DataManager>().Scores.gameHS.scoreList.Add(UIvalues.Score);
    }

    //read highscores
    private void CheckHighScores()
    {
        List<int> temp = FindObjectOfType<DataManager>().Scores.gameHS.scoreList;
        int result=0;
        foreach (var item in temp)
        {
            if (item >= result)
                result = item;
        }
        highScore.text = result.ToString();

    }
}
