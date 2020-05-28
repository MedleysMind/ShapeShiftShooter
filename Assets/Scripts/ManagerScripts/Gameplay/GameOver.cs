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
        // deaths = 0;
    }
    // void Update(){
    //     // Debug.Log(deaths);
    // }
    public void Begin () {
        //Time.timeScale = 1f;
        Destroy (gameObject);
    }
    public static bool restarted;
    public void Restart () {
        GamePlayManager.restartCount++;
        if (GamePlayManager.restartCount == 3) {
            // Reset Restart counter
            GamePlayManager.restartCount = 0;
            // Reload Scene
            SceneManager.LoadScene (1);
            Time.timeScale = 0f;
            // Allows logic to check if ad has finished
            var options = new ShowOptions { resultCallback = HandleShowResult };
            Advertisement.Show (options);
        } else {

            Time.timeScale = 1f;
            SceneManager.LoadScene (1);
        }

    }
    // Checks to see if Ad has finished then runs appropriate logic
    private void HandleShowResult (ShowResult result) {
        switch (result) {
            case ShowResult.Finished:
                Debug.Log ("The ad was successfully shown.");
                //
                AdReset ();
                // YOUR CODE TO REWARD THE GAMER
                // Give coins etc.
                break;
            case ShowResult.Skipped:
                Debug.Log ("The ad was skipped before reaching the end.");
                break;
            case ShowResult.Failed:
                Debug.LogError ("The ad failed to be shown.");
                break;
        }
    }
    public void AdReset () {
        Time.timeScale = 1f;
        restarted = true;
    }
    private GameObject enemy;
    public void KeepGoing () {
        // Allows logic to check if ad has finished
        var options = new ShowOptions { resultCallback = HandleShowResult };
        Advertisement.Show (options);
        Destroy (GameObject.FindGameObjectWithTag ("Enemy"));
        Time.timeScale = 1f;
        Destroy (transform.parent.gameObject);
        Instantiate (Player, gameObject.transform.position, gameObject.transform.rotation);

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