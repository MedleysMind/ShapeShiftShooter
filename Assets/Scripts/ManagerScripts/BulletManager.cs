using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour {
    public AudioSource ShootSound, explosionSound;
    public float speed = 100000;
    public Rigidbody2D rb;
    public int damage = 120;
    public bool triangle, square, hexagon, circle;
    public GameObject explosion;

    void Start () {
        //  ScoreKeeper.scoreValue -= 5;
        //YourScore.scoreValue -= 5;
        ShootSound.Play ();
    // ShapeDetector ();
        
        rb.velocity = transform.right * speed * 100;
        Object.Destroy (gameObject, 3f);
    }

    private void OnTriggerEnter2D (Collider2D hitInfo) {

        CircleEnemy Circleenemy = hitInfo.GetComponent<CircleEnemy> ();
        if (Circleenemy != null) {
            if (circle == true) {
                ScoreCalc (25);
                Circleenemy.TakeCircleDamage (damage);
                BulletEffect ();

            } else {
                BulletEffect ();

            }
        }
        SquareEnemy Squareenemy = hitInfo.GetComponent<SquareEnemy> ();
        if (Squareenemy != null) {
            if (square == true) {
                ScoreCalc (25);
                Squareenemy.TakeSquareDamage (damage);
                BulletEffect ();

            } else {

                BulletEffect ();

            }
        }
        TriEnemy Trienemy = hitInfo.GetComponent<TriEnemy> ();
        if (Trienemy != null) {
            if (triangle == true) {
                ScoreCalc (25);
                Trienemy.TakeTriDamage (damage);
                BulletEffect ();

            } else {
                BulletEffect ();

            }
        }
        HexEnemy Hexenemy = hitInfo.GetComponent<HexEnemy> ();
        if (Hexenemy != null) {
            if (hexagon == true) {
                ScoreCalc (50);
                Hexenemy.TakeHexDamage (damage);
                BulletEffect ();

            } else {
                BulletEffect ();
            }
        }

    }
    public void BulletEffect () {
        // explosionSound.Play();
            LightManager.lightPos = LightManager.lightPos + 6;

        Instantiate (explosion, gameObject.transform.position, gameObject.transform.rotation);
        // Play bullet explosion sound
        Destroy (this.gameObject);
    }
    // public void ShapeDetector () {
    //     if (circle == true) {
    //         speed = 16000f;

    //     }
    //     if (square == true) {
    //         speed = 8000f;
    //     }
    //     if (hexagon == true) {
    //         speed = 60000f;
    //     }
    //     if (triangle == true) {
    //         speed = 12000f;
    //     }
    // }
    public void ScoreCalc (int value) {
        ScoreKeeper.scoreValue += value;
    }

}