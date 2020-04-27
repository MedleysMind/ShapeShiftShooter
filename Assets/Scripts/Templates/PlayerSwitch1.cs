using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwitch1 : MonoBehaviour
{
    public GameObject player, player2;
    void Start()
    {
        StartCoroutine(Example());
    }

    IEnumerator Example()
    {
        yield return new WaitForSeconds(0);
        if (Input.GetButton("Fire2"))
        {

            Instantiate(player, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        if (Input.GetButton("Fire3"))

        {

            Instantiate(player2, transform.position, transform.rotation);
            Destroy(gameObject);

        }

    }
}
