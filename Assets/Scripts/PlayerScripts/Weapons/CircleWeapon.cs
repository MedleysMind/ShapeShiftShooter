using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleWeapon : MonoBehaviour
{
    public Transform firepoint;
    
    public GameObject BulletPrefab;
    private float timestamp, timeBetweenShots = .1f;

    void Update()
    {
        if(Input.GetButton("Fire1")&&Time.time>timestamp)
        {
            
            Shoot();

            timestamp = Time.time + timeBetweenShots;
        }
    }
    void Shoot()
    {
        
        Instantiate(BulletPrefab, firepoint.position, firepoint.rotation);
        //shooting logic

    }
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
      //  Debug.Log(hitInfo.name);
        // Destroy(gameObject);
    }

}
