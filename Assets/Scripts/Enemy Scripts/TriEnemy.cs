using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriEnemy : MonoBehaviour
{
    public GameObject explosion;
    public int Trihealth = 480;
    public int damage = 80;

    private Transform target;

    public void TakeTriDamage(int Tridamage)
    {
        Trihealth -= Tridamage;
       
        if (Trihealth == 0)
        {

            Die();

        }
    }
    void Die()
    {
        {
            // Instantiate(deathEffect, transform.position, Quaternion.identity);
            LightManager.lightPos = LightManager.lightPos + 60;

            ScoreKeeper.scoreValue += 300;
            ScoreKeeper.shapeList.Add(1);

            Instantiate(explosion, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(gameObject);
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
         Despawner Despawner = hitInfo.GetComponent<Despawner>();
        if (Despawner != null)
        {
            // Despawner.TakeDamage(damage);
            Instantiate(explosion, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(gameObject);
        }
    }

}
