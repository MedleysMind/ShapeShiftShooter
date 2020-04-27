﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexEnemy : MonoBehaviour
{
    public GameObject explosion;
    // public Transform Player;
    public int Hexhealth = 240;
    public int damage = 120;

    private Transform target;

    void Start()
    {

    }
    
    private void Update()
    {
        // target = GameObject.FindWithTag("Player").GetComponent<Transform>();

        // transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }

    public void TakeHexDamage(int Hexdamage)
    {
        Hexhealth -= Hexdamage;
        

        if (Hexhealth <= 0)
        {

            Die();

        }
    }
    void Die()
    {
        {
            // Instantiate(deathEffect, transform.position, Quaternion.identity);
            ScoreKeeper.scoreValue += 350;
            YourScore.scoreValue += 350;
            Instantiate(explosion, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(gameObject);
        }
    }

     private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        PlayerController PlayerController = hitInfo.GetComponent<PlayerController>();
        if (PlayerController != null)
        {
            PlayerController.TakeDamage(damage);
            Instantiate(explosion, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(gameObject);
        }
    }

}