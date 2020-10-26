<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountdownTimerScript : MonoBehaviour
{
    public float timeUntilDawn = 270;
    public float timeRemaining;
    public bool runTimer;
    public DisplayTImer timerDisplay;
    // Update is called once per frame
    public void Start()
    {
        runTimer = true;
        timeRemaining = 0;
    }


    void Update()
    {
        if (runTimer)
        {
            if (timeRemaining < timeUntilDawn)
            {
                timeRemaining += Time.deltaTime;
            }
            else
            {
                Debug.Log("YOU SURVIVED THE NIGHT");
                runTimer = false;
                timeRemaining = 0;
            }
        }
        timerDisplay.DisplayTime(timeRemaining);
    }
}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountdownTimerScript : MonoBehaviour
{
    public float timeUntilDawn = 270;
    public float timeRemaining;
    public bool runTimer;
    public DisplayTImer timerDisplay;
    // Update is called once per frame
    public void Start()
    {
        runTimer = true;
        timeRemaining = 0;
    }


    void Update()
    {
        if (runTimer)
        {
            if (timeRemaining < timeUntilDawn)
            {
                timeRemaining += Time.deltaTime;
            }
            else
            {
                Debug.Log("YOU SURVIVED THE NIGHT");
                runTimer = false;
                timeRemaining = 0;
            }
        }
        timerDisplay.DisplayTime(timeRemaining);
    }
}
>>>>>>> 9eded08283690c77846f031d49ae377ccae83217
