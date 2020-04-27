using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firepoint;
    public GameObject BulletPrefab;
   


    void Update() {

      
     if(Input.GetButton("Fire1"))
        { 
            Shoot();
        }
        
    }

    void Shoot()
    {
    
        Instantiate(BulletPrefab, firepoint.position, firepoint.rotation);
        //shooting logic
       
    }
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log(hitInfo.name);
       // Destroy(gameObject);
    }
 
}
