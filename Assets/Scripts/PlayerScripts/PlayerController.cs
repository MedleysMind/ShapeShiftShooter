using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    // private GameObject GameOver;
    public GameObject explosion;
    public static bool dead;
    public static Vector3 playerPos;
     private Vector2 mousePosition;
    public int health = 10;
    public float moveSpeed = 0.1f;
    void Start(){
        // GameOver = GameObject.FindWithTag("GameOver");
    }
    void Update () {
        playerMovement();
        playerPos = transform.position;
    }
    //Health System
    public void TakeDamage (int damage) {
        health -= damage;

        if (health <= 0) {
            PlayerDeath ();

        }
    }
    public void PlayerDeath () {
        Instantiate (explosion, gameObject.transform.position, gameObject.transform.rotation);
        HighScore.highscore += ScoreKeeper.scoreValue;
        Destroy (gameObject);
        dead = true;
    }
    public void playerMovement(){
        mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
    }
}