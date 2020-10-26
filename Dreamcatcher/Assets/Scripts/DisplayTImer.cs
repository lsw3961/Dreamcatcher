using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DisplayTImer : MonoBehaviour
{
    float temp;
    float hours;
    float minutes;
    public Text timeText;
    string ampm;
    void Start()
    {
        ampm = "pm";
        hours = 8;
    }

    void Update()
    {
        
    }

    public void DisplayTime(float timeToDisplay)
    {
        minutes = Mathf.Floor(Mathf.Repeat(timeToDisplay / 5, 6));
        Debug.Log("time: " + (timeToDisplay));
        Debug.Log("time Modulo: " + (timeToDisplay % 30));
        if ((timeToDisplay % 30) <= .003999f)
        {
            hours++;
           
        }
        //hours += temp;
        if (hours>12)
        { 
             ampm = "am";
            hours = 0;
        }
        else
        {
             ampm = "pm";
        }
        timeText.text = string.Format("{0:00}:{1:0}0 {2}", hours, minutes, ampm);
    }
}
