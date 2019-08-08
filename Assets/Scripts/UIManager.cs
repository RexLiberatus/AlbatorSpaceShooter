using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public TMPro.TextMeshProUGUI health;
    public TMPro.TextMeshProUGUI score;

  
    // Start is called before the first frame update
    void Start()
    {
        health.text = "Lives x " + UIvalues.Lives.ToString();
        score.text = UIvalues.Score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        health.text = "LIVES x " + UIvalues.Lives.ToString();
        score.text = UIvalues.Score.ToString();
    }
}
