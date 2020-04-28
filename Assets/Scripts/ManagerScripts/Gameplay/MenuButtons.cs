using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

/*Main Menu Button Controls
 * March 26, 2019
 * Patrick Medley */

public class MenuButtons : MonoBehaviour
{ 
  // private PlayerProgress playerProgress;
    public GameObject PauseMenu;

  
//Unity Ads
    string gameId = "3171681";
  //  bool testMode = true;
    private void Start()
    {
        // GameObject.Find ("LevelSelect").SetActive(false);

        //  LoadPlayerProgress();

//Unity Ads
        Advertisement.Initialize(gameId);
    }
    public void Endless()
    {
        SceneManager.LoadScene(1);
    }
    public void EndLevel()
    {
      //  Advertisement.Show();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void LevelSelect ()
    {
        GameObject.Find ("MainMenu").SetActive(false);
        GameObject.Find ("LevelSelect").SetActive(true);
        SceneManager.LoadScene(2);
    }
    public void BackToMenu()
    {
       // Advertisement.Show();
        SceneManager.LoadScene(0);
    }
    public void Back()
    {
       // Advertisement.Show();
        SceneManager.LoadScene(1);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
public void OpenMenu()
    {
        if(PauseMenu != null)
        {
            PauseMenu.SetActive(true);
        }
        Instantiate(PauseMenu);
        Time.timeScale = 0f;
    }
    public void CloseMenu()
    {
        if (PauseMenu == true)
        {
            PauseMenu.SetActive(false);
        }
        Destroy(transform.parent.gameObject);
        Time.timeScale = 1f;
    }
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
