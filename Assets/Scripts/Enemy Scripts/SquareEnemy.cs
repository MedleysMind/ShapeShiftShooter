using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareEnemy : MonoBehaviour
{
    public GameObject explosion;
    public AudioSource explosionSound;
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
            LightManager.lightPos = LightManager.lightPos + 60;

            ScoreKeeper.scoreValue += 200;

            ScoreKeeper.shapeList.Add(1);
            Instantiate(explosion, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(gameObject);
            
        }
    }
 private void OnTriggerEnter2D(Collider2D hitInfo)
    {
            explosionSound.Play();

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
