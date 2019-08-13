using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class UIvalues :MonoBehaviour
{
    #region Data

    static int lives=4;
  
    static int score=0;
    static int highScore = 0;
    static int killPoints=25;
    #endregion

    #region  Accessors
    public static int Lives { get => lives; set => lives = value; }
    public static int Score { get => score; set => score = value; }
    public static int KillPoints { get => killPoints; set => killPoints = value; }
    #endregion

    #region Methods
    
    #endregion
}
