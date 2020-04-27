using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextDestroyer : MonoBehaviour
{
    
    public float lifetime;

    private void Start()
    {


        Destroy(gameObject, lifetime);
        create();

    }

    public void create()
    { }
    


}