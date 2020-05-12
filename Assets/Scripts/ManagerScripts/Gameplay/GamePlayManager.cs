using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class GamePlayManager : MonoBehaviour {
    public GameObject GameOverMenu, Light;
    public static float livesLost;
    public static float restartCount;
    // private Light2D LightScript;

    // Update is called once per frame
    void LateUpdate () {
        if (ScoreKeeper.scoreValue > 100) {
            // gameObject.Find();
        //    Light.GetComponent<Light2D> ();
            // LightScript.falloffIntensity = 2;
        }
        if (PlayerManager.dead == true) {
            StartCoroutine (PlayerDeath ());
        }
    }

    public IEnumerator PlayerDeath () {
        livesLost++;
        PlayerManager.dead = false;
        yield return new WaitForSeconds (.5f);
        // GameObject.Find ("MENU").SetActive(false);
        Instantiate (GameOverMenu);
        GameObject.Find ("Portrait_GameplayUI").SetActive (false);
        Time.timeScale = 0f;
        if (livesLost >= 3) {
            livesLost = 0;
            Advertisement.Show ();
        }
    }
}