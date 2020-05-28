using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerManager : MonoBehaviour {
    // private GameObject GameOver;
    public GameObject explosion;
    public AudioSource explosionSound;
    public static bool dead;
    public static Vector3 playerPos;
    public static Vector2 mousePosition, newPos, lastPos, screenBounds;
    public int health = 10;
    public float moveSpeed = 0.1f;

    void Start () {
        screenBounds = Camera.main.ScreenToWorldPoint (new Vector3 (Screen.width - 100, Screen.height, Camera.main.transform.position.z));

    }
    void Update () {
        playerMovement ();
        playerPos = transform.position;
    }
    // void LateUpdate () {
    //     newPos = Mathf.Clamp(newPos.x, screenBounds.x, screenBounds.x * -1);
    //     transform.position = newPos;
    // }
    //Health System
    public void TakeDamage (int damage) {
        health -= damage;

        if (health <= 0) {
            explosionSound.Play ();
            PlayerDeath ();

        }
    }
    public void PlayerDeath () {

        Instantiate (explosion, gameObject.transform.position, gameObject.transform.rotation);
        Destroy (gameObject);
        dead = true;
    }
    private LayerMask layer;
    // private Ray2D ray;
    private bool isMouseOverUI () {
        return EventSystem.current.IsPointerOverGameObject ();
    }
    public void playerMovement () {
if(!isMouseOverUI()){
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint (mousePosition);

} else{
    // Swaps player char in correct spot instead of drifting to middle
    newPos = playerPos;
}

        if (transform.position.x < -screenBounds.x) {
          transform.position =  new Vector2(-screenBounds.x, transform.position.y);
        }
        if (transform.position.x > screenBounds.x) {
          transform.position =  new Vector2(screenBounds.x, transform.position.y);
        }
        newPos = new Vector2 (mousePosition.x, transform.position.y);
        transform.position = Vector2.Lerp (transform.position, newPos, moveSpeed);

        // if (transform.position.x > 4345) {
        //    transform.position = new Vector2(4345,playerPos.y);
        // }
        // if (transform.position.x < -4345) {
        //  transform.position =  new Vector2(-4345,playerPos.y);
        // }

    }
}