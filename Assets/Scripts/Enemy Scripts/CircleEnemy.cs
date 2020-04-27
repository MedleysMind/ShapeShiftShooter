using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleEnemy : MonoBehaviour
{
    public GameObject explosion;
    // public Transform Player;
    public int Circlehealth = 240;
    public int damage = 20;

    private Transform target;

    void Start()
    {
        // anim = gameObject.GetComponent<Animation>();
    }
    private void Update()
    {
        // target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        // transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

    }

    public void TakeCircleDamage(int Circledamage)
    {
        Circlehealth -= Circledamage;
        

        if (Circlehealth <= 0)
        {
            
            Die();
            
        }
    }
    void Die()
    {
        {
            ScoreKeeper.scoreValue += 50;
            YourScore.scoreValue += 50;
            // anim.Play("Death Animation");
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
