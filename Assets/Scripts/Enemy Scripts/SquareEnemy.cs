using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareEnemy : MonoBehaviour
{
    public GameObject explosion;
    //  public Transform Player;
    public int Squarehealth = 240;
    public int damage = 40;

    private Transform target;

    void Start()
    {

    }
    private void Update()
    {
        // target = GameObject.FindWithTag("Player").GetComponent<Transform>();

        // transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

    }

    public void TakeSquareDamage(int Squaredamage)
    {
       
        Squarehealth -= Squaredamage;

        if (Squarehealth <= 0)
        {

            Die();

        }
    }
    void Die()
    {
        {
            ScoreKeeper.scoreValue += 100;
            YourScore.scoreValue += 100;
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
