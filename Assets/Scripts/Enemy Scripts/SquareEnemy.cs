﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareEnemy : MonoBehaviour
{
    public GameObject explosion;
    //  public Transform Player;
    public int Squarehealth = 240;
    public int damage = 40;

    private Transform target;


    public void TakeSquareDamage(int Squaredamage)
    {
       
        Squarehealth -= Squaredamage;

        if (Squarehealth == 0)
        {

            Die();

        }
    }
    void Die()
    {
        {
            ScoreKeeper.scoreValue += 100;

            Instantiate(explosion, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(gameObject);
            ScoreKeeper.shapeList.Add(1);
            
        }
    }
 private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        PlayerManager PlayerManager = hitInfo.GetComponent<PlayerManager>();
        if (PlayerManager != null)
        {
            PlayerManager.TakeDamage(damage);
            Instantiate(explosion, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(gameObject);
        }
    }

}
