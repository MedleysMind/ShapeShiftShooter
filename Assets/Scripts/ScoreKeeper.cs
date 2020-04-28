using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour {
    public static List<int> shapeList = new List<int> ();
    private MenuButtons menuButtons;
    public static int scoreValue = 0;
    public static float totalShapes, totalPoints;
    public Text score;
    public Text shapes;
    public Text total;
    public Text HighScores;

    void Start () {
        // scoreValue = 0;
        // score = GetComponent<Text>(); 
    }

    public void Update () {
        totalShapes = shapeList.Count;
        totalPoints = scoreValue * totalShapes;
        score.text = scoreValue.ToString();
        shapes.text = totalShapes.ToString();
        if(PlayerManager.dead == true){
        total.text = scoreValue.ToString() +" x " + totalShapes.ToString() +" = " + totalPoints.ToString();
        }
        // menuButtons.SubmitNewPlayerScore(playerScore);
        //score.text = menuButtons.GetHighestPlayerScore().ToString();
    }
}