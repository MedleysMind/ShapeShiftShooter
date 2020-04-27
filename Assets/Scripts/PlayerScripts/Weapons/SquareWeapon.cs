using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareWeapon : MonoBehaviour
{
    public Transform firepoint, firepoint1, firepoint2, firepoint3;
    public GameObject BulletPrefab;
    private float timestamp, timeBetweenShots = .25f;

    void Update()
    {
       
        if (Input.GetButton("Fire1") && Time.time > timestamp)
        {
                Shoot();
            timestamp = Time.time + timeBetweenShots;
        }
        }

    void Shoot()
    {
        
            //Center Bullet
            Instantiate(BulletPrefab, firepoint.position, firepoint.rotation);
        //Center Bullet
        Instantiate(BulletPrefab, firepoint1.position, firepoint1.rotation);
        //Right Bullet
        Instantiate(BulletPrefab, firepoint2.position, firepoint2.rotation);
            //Left Bullet
            Instantiate(BulletPrefab, firepoint3.position, firepoint3.rotation);

    }
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
       // Debug.Log(hitInfo.name);
        // Destroy(gameObject);
    }

}
