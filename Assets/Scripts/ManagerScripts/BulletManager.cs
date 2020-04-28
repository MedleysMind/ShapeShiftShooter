using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour {
    public AudioSource ShootSound;
    private float speed;
    public Rigidbody2D rb;
    public int damage = 120;
    public bool triangle, square, hexagon, circle;

    void Start () {
        //  ScoreKeeper.scoreValue -= 5;
        //YourScore.scoreValue -= 5;
        ShootSound.Play ();
        ShapeDetector ();
        rb.velocity = transform.right * speed;
        Object.Destroy (gameObject, 3f);
    }

    private void OnTriggerEnter2D (Collider2D hitInfo) {

        CircleEnemy Circleenemy = hitInfo.GetComponent<CircleEnemy> ();
        if (Circleenemy != null) {
            if (circle == true) {
                ScoreCalc (10);
                Circleenemy.TakeCircleDamage (damage);
                Destroy (gameObject);
            } else {
                Destroy (gameObject);
            }
        }
        SquareEnemy Squareenemy = hitInfo.GetComponent<SquareEnemy> ();
        if (Squareenemy != null) {
            if (square == true) {
                ScoreCalc (10);
                Squareenemy.TakeSquareDamage (damage);
                Destroy (gameObject);
            } else {

                Destroy (gameObject);
            }
        }
        TriEnemy Trienemy = hitInfo.GetComponent<TriEnemy> ();
        if (Trienemy != null) {
            if (triangle == true) {
                ScoreCalc (20);
                Trienemy.TakeTriDamage (damage);
                Destroy (gameObject);
            } else {
                Destroy (gameObject);
            }
        }
        HexEnemy Hexenemy = hitInfo.GetComponent<HexEnemy> ();
        if (Hexenemy != null) {
            if (hexagon == true) {
                ScoreCalc (30);
                Hexenemy.TakeHexDamage (damage);
                Destroy (gameObject);
            } else {
                Destroy (gameObject);
            }
        }

    }
    public void ShapeDetector () {
        if (circle == true) {
            speed = 16000f;

        }
        if (square == true) {
            speed = 8000f;
        }
        if (hexagon == true) {
            speed = 20000f;
        }
        if (triangle == true) {
            speed = 12000f;
        }
    }
    public void ScoreCalc (int value) {
        ScoreKeeper.scoreValue += value;
    }

}