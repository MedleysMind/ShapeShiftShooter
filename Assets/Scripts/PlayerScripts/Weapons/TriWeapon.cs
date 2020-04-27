using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriWeapon : MonoBehaviour
{
    public Transform firepoint, firepoint1, firepoint2;
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
       
        Instantiate(BulletPrefab, firepoint.position, firepoint.rotation);
        Instantiate(BulletPrefab, firepoint1.position, firepoint.rotation);
        Instantiate(BulletPrefab, firepoint2.position, firepoint.rotation);
        //shooting logic

    }
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
       // Debug.Log(hitInfo.name);
        // Destroy(gameObject);
    }

}