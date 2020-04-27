using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SquareBullet : MonoBehaviour
{
    public AudioSource ShootSound, CollideSound;
    public float speed = 800f;
    public Rigidbody2D rb;
    public int Squaredamage = 40;
    public int Squarehealth = 1000;

    void Start()
    {
       // ScoreKeeper.scoreValue -= 5;
       // YourScore.scoreValue -= 5;
        ShootSound.Play();
        rb.velocity = transform.right * speed;
            Object.Destroy(gameObject, 3.5f);
        
    }

    public void TakeSquareDamage(int Squaredamage)
    {
        Squarehealth -= Squaredamage;

        if (Squarehealth <= 0)
        {

            Destroy(gameObject);

        }
    }
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
       // CollideSound.Play();

        SquareEnemy Squareenemy = hitInfo.GetComponent<SquareEnemy>();
        if (Squareenemy != null)
        {
            ScoreKeeper.scoreValue += 10;
            YourScore.scoreValue += 10;
            Squareenemy.TakeSquareDamage(Squaredamage);
            Destroy(gameObject);
           
        }
       CircleEnemy Circleenemy = hitInfo.GetComponent<CircleEnemy>();
        if (Circleenemy != null)
        {
            Destroy(gameObject);
           
        }
        TriEnemy Trienemy = hitInfo.GetComponent<TriEnemy>();
        if (Trienemy != null)
        {
            Destroy(gameObject);
            
        }
        HexEnemy Hexenemy = hitInfo.GetComponent<HexEnemy>();
        if (Hexenemy != null)
        {
            Destroy(gameObject);
            
        }

    }   
}
