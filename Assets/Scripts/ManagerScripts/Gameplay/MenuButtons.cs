using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;

/*Main Menu Button Controls
 * March 26, 2019
 * Patrick Medley */

public class MenuButtons : MonoBehaviour {
    // private PlayerProgress playerProgress;
    public GameObject PauseMenu, HighscoreMenu, MainMenuUI, TutorialMenu, CreditMenu;
    //Unity Ads
    string gameId = "3171681";
    //  bool testMode = true;
    private void Start () {
        //  LoadPlayerProgress();
        //Unity Ads
        Advertisement.Initialize (gameId);
    }
    public void Pause () {
        if (PauseMenu.activeInHierarchy == false) {
            PauseMenu.SetActive (true);
            Time.timeScale = 0f;
        } else {
            PauseMenu.SetActive (false);
            Time.timeScale = 1f;
        }
    }
    public void EndlessMode () {
        Time.timeScale = 1f;
        SceneManager.LoadScene (1);
    }
    // Displays the High Score Window in the Main Menu
    public void HighScore () {
        if (HighscoreMenu.activeInHierarchy == false) {
            //closes other windows if open
            CreditMenu.SetActive (false);
            TutorialMenu.SetActive (false);
            //open high scores
            HighscoreMenu.SetActive (true);

        } else {
            HighscoreMenu.SetActive (false);
        }
    }
    // Displays the Tutorial Window in the Main Menu
    public void Tutorial () {
        if (TutorialMenu.activeInHierarchy == false) {
            //closes other windows if open
            CreditMenu.SetActive (false);
            HighscoreMenu.SetActive (false);
            //open tutorial
            TutorialMenu.SetActive (true);
        } else {

            TutorialMenu.SetActive (false);
        }
    }
    // Displays the Credits Window in the Main Menu
    public void Credit () {
        if (CreditMenu.activeInHierarchy == false) {
            //closes other windows if open
            TutorialMenu.SetActive (false);
            HighscoreMenu.SetActive (false);
            //open credits
            CreditMenu.SetActive (true);
        } else {
            CreditMenu.SetActive (false);
        }

    }
    public void BackToMenu () {
        // Advertisement.Show();
        SceneManager.LoadScene (0);
    }
    public void ExitGame () {
        Application.Quit ();
    }

    // public void CloseMenu () {
    //     if (PauseMenu == true) {
    //         PauseMenu.SetActive (false);
    //     }
    //     Destroy (transform.parent.gameObject);
    //     Time.timeScale = 1f;
    // }
    /*   public void SubmitNewPlayerScore(int newScore)
    {
        if (newScore > playerProgress.highestScore)
        {
            playerProgress.highestScore = newScore;
            SavePlayerProgress();
        }
    }

    public int GetHighestPlayerScore()
    {
        return playerProgress.highestScore;
    }

    private void LoadPlayerProgress()
    {
        playerProgress = new PlayerProgress();


    }

    private void SavePlayerProgress()
    {
        PlayerPrefs.SetInt("highestScore", playerProgress.highestScore);
    }
*/
}