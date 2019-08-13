using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SocreManager : MonoBehaviour
{
    public TMPro.TextMeshProUGUI playerScore;
    public TMPro.TextMeshProUGUI highScore;

    void Awake()
    {
        playerScore.text = UIvalues.Score.ToString();

    }
    private void Start()
    {
        RecordScore();
        CheckHighScores();
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
