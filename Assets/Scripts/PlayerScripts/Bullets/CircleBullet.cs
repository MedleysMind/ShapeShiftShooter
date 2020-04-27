using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CircleBullet : MonoBehaviour
{
    public AudioSource ShootSound;
    public float speed = 15000f;
    public Rigidbody2D rb;
    public int Circledamage = 120;
    

    void Start()
    {
      //  ScoreKeeper.scoreValue -= 5;
        //YourScore.scoreValue -= 5;
        ShootSound.Play();
        rb.velocity = transform.right * speed;
        Object.Destroy(gameObject, 2.75f);
    }


    private void OnTriggerEnter2D(Collider2D hitInfo)
    {

        CircleEnemy Circleenemy = hitInfo.GetComponent<CircleEnemy>();
        if (Circleenemy != null)
        {
            ScoreKeeper.scoreValue += 10;
            YourScore.scoreValue += 10;
            Circleenemy.TakeCircleDamage(Circledamage);

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
        HexEnemy Hexenemy = hitInfo.GetComponent<HexEnemy>();
        if (Hexenemy != null)
        {
            Destroy(gameObject);
        }
    
        
    }

}
