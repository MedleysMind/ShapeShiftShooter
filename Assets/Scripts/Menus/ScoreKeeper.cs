using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
  
    private MenuButtons menuButtons;
    public static int scoreValue = 0;
    Text score;

    void Start(){
        scoreValue = 0;
        score = GetComponent<Text>(); 
    }


    public void Update()
  
    {
    score.text = "" + scoreValue;
       
       // menuButtons.SubmitNewPlayerScore(playerScore);
        //score.text = menuButtons.GetHighestPlayerScore().ToString();
    }
}
