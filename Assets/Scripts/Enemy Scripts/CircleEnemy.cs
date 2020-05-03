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
        

        if (Circlehealth == 0)
        {
            
            Die();
            
        }
    }
    void Die()
    {
        {
            LightManager.lightPos = LightManager.lightPos + 60;
            ScoreKeeper.scoreValue += 100;
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
