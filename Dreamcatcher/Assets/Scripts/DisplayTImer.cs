using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DisplayTImer : MonoBehaviour
{
    float moduloTime;
    public bool workAround;
    float temp;
    float hours;
    float minutes;
    public Text timeText;
    string ampm;
    void Start()
    {
        ampm = "pm";
        hours = 8;
        moduloTime = 5;
    }

    void Update()
    {
        
    }

    public void DisplayTime(float timeToDisplay)
    {
        minutes = Mathf.Floor(Mathf.Repeat(timeToDisplay / 5, 6));
        Debug.Log("time: " + (timeToDisplay));
        Debug.Log("time Modulo: " + ((timeToDisplay % 3) + 2));

        moduloTime -= Time.deltaTime;
        
        if (Mathf.FloorToInt(timeToDisplay % 30) < 1 &&moduloTime<0)
        {
            hours++;
            moduloTime = 5;
        }
        if (hours == 12)
        {
            ampm = "am";
        }
        if (hours>12)
        { 
            hours = 1;
        }
        else
        {
             ampm = "pm";
        }
        timeText.text = string.Format("{0:00}:{1:0}0 {2}", hours, minutes, ampm);
    }
}
