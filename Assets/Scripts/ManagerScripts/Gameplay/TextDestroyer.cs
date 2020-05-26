using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextDestroyer : MonoBehaviour
{
    
    public float lifetime;
    public GameObject NextText;

    private void Start()
    {


        Destroy(gameObject, lifetime);
        create();

    }

    public void create()
    {
        NextText.SetActive (true);
     }
    


}