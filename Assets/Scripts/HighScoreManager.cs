using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreManager : MonoBehaviour
{
        public Text HighScores, total, baseScore, shapeTotal;

        public void Start(){
           
        }
public void Update () {
        ScoreKeeper.totalPoints = ScoreKeeper.scoreValue * ScoreKeeper.totalShapes;
        total.text = ScoreKeeper.totalPoints.ToString();
        shapeTotal.text = ScoreKeeper.totalShapes.ToString();
        baseScore.text = ScoreKeeper.scoreValue.ToString();
//         for(var i = 0; i < ScoreKeeper.scoreValue; i++){
//                 i++;
//                 baseScore.text = i.ToString();
// Debug.Log(i);
//         }
}
}
