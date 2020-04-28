using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public int Minutes, Seconds;
    public Text timerText;
    private float startTime;
  //  private bool finished = false;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
      
        float t = Time.time - startTime;
        float f = Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("00");

        timerText.text = minutes + ":" + seconds;

       Minutes = ((int)f / 60);
       // Seconds = (f % 60);
    }
    

}
