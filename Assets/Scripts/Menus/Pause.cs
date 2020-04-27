using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
    
{
    public GameObject PauseMenu;
    // Start is called before the first frame update

    // Update is called once per frame

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
}
