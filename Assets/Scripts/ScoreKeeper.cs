using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour {
    public static List<int> shapeList = new List<int> ();
    // public static List<string> HighScores = new List<string> ();
    private MenuButtons menuButtons;
    public static int scoreValue = 0;
    public static float totalShapes, totalPoints;
    public Text score;
    public Text shapes;
void Start(){
    ScoreKeeper.shapeList.Clear();
         ScoreKeeper.scoreValue = 0;
}
    public void Update () {
        totalShapes = shapeList.Count;
        score.text = scoreValue.ToString ();
        shapes.text = totalShapes.ToString ();

        // if (scoreValue > highscore) {
        //     high
        // }
    }
}