using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class HexBullet : MonoBehaviour
{
    public AudioSource ShootSound, CollideSound;
    public float speed = 2400f;
    public Rigidbody2D rb;
    public int Hexdamage = 240;

    void Start()
    {
       // ScoreKeeper.scoreValue -= 15;
        //YourScore.scoreValue -= 15;
        ShootSound.Play();
        rb.velocity = transform.right * speed;
        Object.Destroy(gameObject, 3f);
    }


    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        

        HexEnemy Hexenemy = hitInfo.GetComponent<HexEnemy>();
        if (Hexenemy != null)
        {
            ScoreKeeper.scoreValue += 30;
            YourScore.scoreValue += 30;
            Hexenemy.TakeHexDamage(Hexdamage);

            Destroy(gameObject);
        }
        SquareEnemy Squareenemy = hitInfo.GetComponent<SquareEnemy>();
        if (Squareenemy != null)
        {
            Destroy(gameObject);
        }
        TriEnemy Trienemy = hitInfo.GetComponent<TriEnemy>();
        if (Trienemy != null)
        {
            Destroy(gameObject);
        }
        CircleEnemy Circleenemy = hitInfo.GetComponent<CircleEnemy>();
        if (Circleenemy != null)
        {
            Destroy(gameObject);
        }
       
    }

}
