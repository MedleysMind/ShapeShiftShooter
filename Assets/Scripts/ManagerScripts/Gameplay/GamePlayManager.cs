using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayManager : MonoBehaviour
{
    public GameObject GameOver;
    public static float livesLost;


    // Update is called once per frame
    void Update()
    {
        if(PlayerController.dead == true){
            StartCoroutine(PlayerDeath());
        }
    }

    IEnumerator PlayerDeath(){
        livesLost++;
        yield return new WaitForSeconds (.5f);
        Destroy (GameObject.FindWithTag ("MENU"));
        Instantiate (GameOver);
        Time.timeScale = 0f;
        PlayerController.dead = false;
    }
}
