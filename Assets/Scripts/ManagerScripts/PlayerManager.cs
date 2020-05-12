using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {
    // private GameObject GameOver;
    public GameObject explosion;
    public AudioSource explosionSound;
    public static bool dead;
    public static Vector3 playerPos;
    private Vector2 mousePosition, newPos, screenBounds;
    public int health = 10;
    public float moveSpeed = 0.1f;

void Start()    {
    screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
}
    void Update () {
        playerMovement ();
        playerPos = transform.position;
    }
    void LateUpdate(){
        // newPos = Mathf.Clamp(newPos.x, screenBounds.x, screenBounds.x * -1);
        // transform.position = newPos;
    }
    //Health System
    public void TakeDamage (int damage) {
        health -= damage;

        if (health <= 0) {
            PlayerDeath ();

        }
    }
    public void PlayerDeath () {
        explosionSound.Play();
        Instantiate (explosion, gameObject.transform.position, gameObject.transform.rotation);
        Destroy (gameObject);
        dead = true;
    }
    public void playerMovement () {

        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint (mousePosition);
        // transform.position = new Vector2 (mousePosition.x,transform.position.y);
        newPos = new Vector2 (mousePosition.x,transform.position.y);
        transform.position =  Vector2.Lerp (transform.position,newPos, moveSpeed);

        
        // if (transform.position.y < -5575 || transform.position.y > -5300) {
        //   transform.position =  new Vector2(playerPos.x, -5575);
        // }
        // if (transform.position.x > 4345) {
        //    transform.position = new Vector2(4345,playerPos.y);
        // }
        // if (transform.position.x < -4345) {
        //  transform.position =  new Vector2(-4345,playerPos.y);
        // }

    }
}