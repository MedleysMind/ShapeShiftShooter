using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WeaponController : MonoBehaviour {
    public Transform firepoint, firepoint1, firepoint2, firepoint3;

    public GameObject BulletPrefab;
    private float timestamp, timeBetweenShots;
    public bool triangle, square, hexagon, circle;

    void Start () {
        if (triangle == true || square == true) {
            timeBetweenShots = .5f;
        }
        if (hexagon == true) {
            timeBetweenShots = .75f;
        }

        if (circle == true) {
            timeBetweenShots = .1f;
        }
    }
    void Update () {
        if (!EventSystem.current.IsPointerOverGameObject ()) {
            if (Input.GetButton ("Fire1") && Time.time > timestamp) {

                Shoot ();

                timestamp = Time.time + timeBetweenShots;
            }
        }
    }
    void Shoot () {
        if (triangle == true || hexagon == true) {
            Instantiate (BulletPrefab, firepoint.position, firepoint.rotation);
            Instantiate (BulletPrefab, firepoint1.position, firepoint.rotation);
            Instantiate (BulletPrefab, firepoint2.position, firepoint.rotation);
        }
        if (square == true) {
            Instantiate (BulletPrefab, firepoint.position, firepoint.rotation);
            Instantiate (BulletPrefab, firepoint1.position, firepoint.rotation);
            Instantiate (BulletPrefab, firepoint2.position, firepoint.rotation);
            Instantiate (BulletPrefab, firepoint3.position, firepoint.rotation);
        }
        Instantiate (BulletPrefab, firepoint.position, firepoint.rotation);
        //shooting logic

    }

}