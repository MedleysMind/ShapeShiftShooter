using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TriBullet : MonoBehaviour
{
    public AudioSource ShootSound;
    public float speed = 1400f;
    public Rigidbody2D rb;
    public int Tridamage = 120;


    void Start()
    {
      //  ScoreKeeper.scoreValue -= 10;
      //  YourScore.scoreValue -= 10;
        ShootSound.Play();
        rb.velocity = transform.right * speed;
        Object.Destroy(gameObject, 3f);
    }


    private void OnTriggerEnter2D(Collider2D hitInfo)
    {

        TriEnemy trienemy = hitInfo.GetComponent<TriEnemy>();
        if (trienemy != null)
        {
            ScoreKeeper.scoreValue += 20;
            YourScore.scoreValue += 20;
            trienemy.TakeTriDamage(Tridamage);

            Destroy(gameObject);
        }
        SquareEnemy Squareenemy = hitInfo.GetComponent<SquareEnemy>();
        if (Squareenemy != null)
        {
            Destroy(gameObject);
        }
        CircleEnemy Circleenemy = hitInfo.GetComponent<CircleEnemy>();
        if (Circleenemy != null)
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