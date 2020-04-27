using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class HighScore : MonoBehaviour
{

    public static int highscore, scoreValue;
    Text text;

    void Start()
    {
        text = GetComponent<Text>();

        

        highscore = PlayerPrefs.GetInt("highscore", highscore);
        text.text = highscore.ToString();
    }


    public  void Update()
    {
    
        text.text = "" + highscore;
    }
}
