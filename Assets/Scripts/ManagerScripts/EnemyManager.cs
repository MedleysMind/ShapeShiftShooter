using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {
    public GameObject explosion;
    private int TriHealth, SquareHealth, CircleHealth, HexHealth;

    private Transform target;
    public bool triangle, square, hexagon, circle;

    void Start () {
        ShapeDetector ();
    }
    public void TakeTriDamage (int damage) {
        TriHealth -= damage;
        if (TriHealth <= 0) {
            Die ();
        }
    }
    public void TakeSquareDamage(int Squaredamage)
    {
        SquareHealth -= Squaredamage;
        if (SquareHealth <= 0)
        {
            Die();
        }
    }
    public void TakeCircleDamage(int Circledamage)
    {
        CircleHealth -= Circledamage;
        

        if (CircleHealth <= 0)
        {
            
            Die();
            
        }
    }public void TakeHexDamage(int Hexdamage)
    {
        HexHealth -= Hexdamage;
        

        if (HexHealth <= 0)
        {

            Die();

        }
    }
    void Die () {
        {
            // Instantiate(deathEffect, transform.position, Quaternion.identity);
            ScoreKeeper.scoreValue += 250;
            Instantiate (explosion, gameObject.transform.position, gameObject.transform.rotation);
            Destroy (gameObject);
        }
    }

    private void OnTriggerEnter2D (Collider2D hitInfo) {
        PlayerManager PlayerManager = hitInfo.GetComponent<PlayerManager> ();
        if (PlayerManager != null) {
            // PlayerManager.TakeDamage (damage);
            Instantiate (explosion, gameObject.transform.position, gameObject.transform.rotation);
            Destroy (gameObject);
        }
    }
    public void ShapeDetector () {
        if (circle == true) {
            // health = 960;
            // damage = 120;

        }
        if (square == true) {
            // health = 480;
            // damage = 120;

        }
        if (triangle == true || hexagon == true) {
            // health = 720;
            // damage = 120;

        }
    }
}