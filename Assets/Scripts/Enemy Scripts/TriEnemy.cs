using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriEnemy : MonoBehaviour
{
    public GameObject explosion;
    public Transform Player;
    public int Trihealth = 240;
    public int damage = 80;

    private Transform target;

    public void TakeTriDamage(int Tridamage)
    {
        Trihealth -= Tridamage;
       
        if (Trihealth <= 0)
        {

            Die();

        }
    }
    void Die()
    {
        {
            // Instantiate(deathEffect, transform.position, Quaternion.identity);
            ScoreKeeper.scoreValue += 250;
            YourScore.scoreValue += 250;
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
