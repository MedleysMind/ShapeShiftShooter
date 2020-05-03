using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawner : MonoBehaviour {
    // Start is called before the first frame updat
    private void OnTriggerEnter2D (Collider2D hitInfo) {

        CircleEnemy Circleenemy = hitInfo.GetComponent<CircleEnemy> ();
        if (Circleenemy != null) {
            
                ScoreCalc (-200);
                Circleenemy.TakeCircleDamage (1000);

        }
        SquareEnemy Squareenemy = hitInfo.GetComponent<SquareEnemy> ();
        if (Squareenemy != null) {
            
                ScoreCalc (-200);
                Squareenemy.TakeSquareDamage (1000);
            
        }
        TriEnemy Trienemy = hitInfo.GetComponent<TriEnemy> ();
        if (Trienemy != null) {
                ScoreCalc (-200);
                Trienemy.TakeTriDamage (1000);

        }
        HexEnemy Hexenemy = hitInfo.GetComponent<HexEnemy> ();
        if (Hexenemy != null) {
                ScoreCalc (-200);
                Hexenemy.TakeHexDamage (1000);

        }

        
    }
    public void ScoreCalc (int value) {
            ScoreKeeper.scoreValue += value;
        }
}