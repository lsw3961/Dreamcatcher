
﻿using System.Collections;
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
        moduloTime = 1.5f;
    }

    void Update()
    {

    }

    public void DisplayTime(float timeToDisplay)
    {
        minutes = Mathf.Floor(Mathf.Repeat(timeToDisplay / 1.5f, 6));

        moduloTime -= Time.deltaTime;

        if (Mathf.FloorToInt(timeToDisplay % 9) < 1 && moduloTime < 0)
        {
            hours++;
            moduloTime = 1.5f;
        }
        if (hours > 12)
        {
            hours = 1;
        }
        if (hours == 12 || hours < 8)
        {
            ampm = "am";
        }
        else
        {
            ampm = "pm";
        }
        timeText.text = string.Format("{0:00}:{1:0}0 {2}", hours, minutes, ampm);
    }
}
