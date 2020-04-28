using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class GamePlayManager : MonoBehaviour
{
    public GameObject GameOver;
    public static float livesLost;


    // Update is called once per frame
    void LateUpdate()
    {
        if(PlayerManager.dead == true){
            StartCoroutine(PlayerDeath());
        }
    }

    public IEnumerator PlayerDeath(){
        livesLost++;
        PlayerManager.dead = false;
        yield return new WaitForSeconds (.5f);
        // GameObject.Find ("MENU").SetActive(false);
        Instantiate (GameOver);
        Time.timeScale = 0f;
        if (livesLost >= 3) {
            livesLost = 0;
            Advertisement.Show ();
        }
    }
}
