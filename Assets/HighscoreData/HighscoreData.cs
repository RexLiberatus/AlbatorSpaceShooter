using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    [CreateAssetMenu(fileName ="HighScoreData",menuName = "Data/HighScore",order =0)]
public class HighscoreData : ScriptableObject
{
    [System.Serializable]
    public class HighScoreData
    {
        public List<int> scoreList;
    }
    public HighScoreData gameHS;

}
