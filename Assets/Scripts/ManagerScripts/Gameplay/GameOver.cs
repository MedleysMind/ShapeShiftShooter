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
    public GameObject Player;
    // , ScoreBox, ScoreBox2, RestartMenu;
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
        Time.timeScale = 1f;
        SceneManager.LoadScene (1);

    }
    // public void Restart2 () {
    //     SceneManager.LoadScene (1);
    // }
    private GameObject enemy;
    public void KeepGoing () {
Advertisement.Show ();
        Time.timeScale = 1f;
       GameObject.FindGameObjectWithTag("Enemy");
    //    Destroy();
        Instantiate (Player, gameObject.transform.position, gameObject.transform.rotation);
        Destroy (transform.parent.gameObject);

    }
    public void BackToMain () {

        Advertisement.Show ();
        ScoreKeeper.scoreValue = 0;
        SceneManager.LoadScene (0);
    }
    // public void BackToSelect () {
    //     Advertisement.Show ();
    //     SceneManager.LoadScene (1);
    // }
}