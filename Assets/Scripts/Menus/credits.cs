using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class credits : MonoBehaviour
{
    public GameObject CreditsMenu;
    public void OpenMenu()
    {

        if (CreditsMenu != null)
        {
           CreditsMenu.SetActive(true);
        }
        Instantiate(CreditsMenu);
        Time.timeScale = 0f;
    }
    public void CloseMenu()
    {
        if (CreditsMenu == true)
        {
            CreditsMenu.SetActive(false);
        }
        Destroy(transform.parent.gameObject);
        Time.timeScale = 1f;
    }
}
