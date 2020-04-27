using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*Game Over Menu Button Controls
 * April 4, 2019
 * Patrick Medley */

public class GameOver : MonoBehaviour {
    public Text timerText;
    public GameObject Player, ScoreBox, ScoreBox2, RestartMenu;
    //Unity Ads
    string gameId = "3171681";
    // bool testMode = true;

    void Start () {
        Advertisement.Initialize (gameId);
        Time.timeScale = 0f;
    }
    public void Begin () {
        //Time.timeScale = 1f;
        Destroy (gameObject);
    }
    public void Restart () {
        HighScore.highscore -= HighScore.highscore;
        Time.timeScale = 0f;
        // Instantiate(RestartMenu);
        // Destroy(gameObject);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        if (GamePlayManager.livesLost >= 3) {
            GamePlayManager.livesLost = 0;
            Advertisement.Show ();
        } else {
            SceneManager.LoadScene (1);
        }

    }
    // public void Restart2 () {
    //     SceneManager.LoadScene (1);
    // }
    public void KeepGoing () {

        Instantiate (Player);
        Destroy (ScoreBox);
        Destroy (ScoreBox2);

        //     GameObject[] gos = GameObject.FindGameObjectsWithTag("Enemy");
        //     foreach (GameObject go in gos)
        //        Destroy(go);
        Time.timeScale = 1f;
        Destroy (transform.parent.gameObject);

    }
    public void BackToMain () {
        Advertisement.Show ();
        SceneManager.LoadScene (0);
    }
    public void BackToSelect () {
        Advertisement.Show ();
        SceneManager.LoadScene (1);
    }
}