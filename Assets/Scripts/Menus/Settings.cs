using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public GameObject OptionsMenu;
    public void OpenMenu()
    {
        
        if (OptionsMenu != null)
        {
            OptionsMenu.SetActive(true);
        }
        Instantiate(OptionsMenu);
        Time.timeScale = 0f;
    }
    public void CloseMenu()
    {
        if (OptionsMenu == true)
        {
            OptionsMenu.SetActive(false);
        }
        Destroy(transform.parent.gameObject);
        Time.timeScale = 1f;
    }
}
