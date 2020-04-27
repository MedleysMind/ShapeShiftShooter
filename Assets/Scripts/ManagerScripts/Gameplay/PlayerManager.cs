using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerManager : MonoBehaviour
{
    public float RotateSpeed = 35f;
    public int Circlehealth = 10;
    public int hexdamage = 1000;
    public int circledamage = 1000;
    public int Squaredamage = 1000;
    public int Tridamage = 1000;
    private float timestamp = 2;
    public GameObject GameOver, player;

    //Weapon
    public Transform firepoint;
    public GameObject BulletPrefab;
    private float timeBetweenShots = .15f;
    //Bullet
    public static PlayerManager SharedInstance;
    public List<GameObject> pooledObjects;
    public GameObject objectToPool;
    public int amountToPool;

    void Awake()
    {
        SharedInstance = this;
    }
    void Start()
    {
        pooledObjects = new List<GameObject>();
        for (int i = 0; i < amountToPool; i++)
        {
            GameObject obj = (GameObject)Instantiate(objectToPool);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }
    }


    void Update()
    {
        //Player Rotates to Follow Mouse
        Vector3 mouseScreen = Input.mousePosition;
        Vector3 mouse = Camera.main.ScreenToWorldPoint(mouseScreen);
        transform.rotation = Quaternion.Euler(0, 0, Mathf.Atan2(mouse.y - transform.position.y, mouse.x - transform.position.x) * Mathf.Rad2Deg - 90);

        if (Time.time >= timestamp && (Input.GetButtonDown("Fire1")))
        {
            Shoot();
            timestamp = Time.time + timeBetweenShots;
        }

        /* Mouse Key Rotational Controls
          if (Input.GetKey(KeyCode.RightArrow))
              transform.Rotate(Vector3.back * RotateSpeed / 4);   
          else if (Input.GetKey(KeyCode.LeftArrow)) 
                  transform.Rotate(Vector3.forward * RotateSpeed / 4);
        */

        //Time Delay Before Allowed Input And Call to Swap Function 
        if (Time.time >= timestamp && (Input.GetButtonDown("Fire2")))
        {
            Swap();
        }

    }
    void Shoot()
    {

        /*meObject bulletPrefab = ObjectPooler.SharedInstance.GetPooledObject();
        if (bulletPrefab != null)
        {
            bulletPrefab.transform.position = firepoint.transform.position;
            bulletPrefab.transform.rotation = firepoint.transform.rotation;
            bulletPrefab.SetActive(true);
        }
        //shooting logic
        */
    }
    public void Swap()
    {

        Instantiate(player, transform.position, transform.rotation);
        Destroy(gameObject);
    }
    public void TakeDamage(int damage)
    {
        Circlehealth -= damage;

        if (Circlehealth <= 0)
        {
            Destroy(gameObject);
            Destroy(GameObject.FindWithTag("MENU"));

            Instantiate(GameOver);
            Debug.Log("Game Over Screen");
            Time.timeScale = 0f;
        }
    }
    public void TakeCircleDamage(int Circledamage)
    {
        Circlehealth -= Circledamage;

        if (Circlehealth <= 0)
        {
            Destroy(gameObject);
            Destroy(GameObject.FindWithTag("MENU"));

            Instantiate(GameOver);
            Debug.Log("Game Over Screen");
            Time.timeScale = 0f;

        }
    }
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        HexEnemy hexenemy = hitInfo.GetComponent<HexEnemy>();
        if (hexenemy != null)
        {
            hexenemy.TakeHexDamage(hexdamage);
        }
        CircleEnemy circleenemy = hitInfo.GetComponent<CircleEnemy>();
        if (circleenemy != null)
        {
            circleenemy.TakeCircleDamage(circledamage);
        }
        SquareEnemy squareenemy = hitInfo.GetComponent<SquareEnemy>();
        if (squareenemy != null)
        {
            squareenemy.TakeSquareDamage(Squaredamage);
        }
        TriEnemy trienemy = hitInfo.GetComponent<TriEnemy>();
        if (trienemy != null)
        {
            trienemy.TakeTriDamage(Tridamage);
        }
       
    }
}
