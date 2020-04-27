using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class YourScore : MonoBehaviour
{

    public static int scoreValue;
    Text score;

    void Start()
    {
        score = GetComponent<Text>();
    }


    private void Update()

    {
        score.text = "Your Score:  " + scoreValue;

        // menuButtons.SubmitNewPlayerScore(playerScore);
        //score.text = menuButtons.GetHighestPlayerScore().ToString();
    }
}
