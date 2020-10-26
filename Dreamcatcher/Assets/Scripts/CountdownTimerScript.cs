using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountdownTimerScript : MonoBehaviour
{
    public SceneTransitionLoading changeScenes;
    public static int dayNumber = 1;
    public float timeUntilDawn = 270;
    public float timeRemaining;
    public bool runTimer;
    public DisplayTImer timerDisplay;
    public Text dayText;

    public int DayNumber
    {
        get { return dayNumber; }
    }
    // Update is called once per frame
    public void Start()
    {
        runTimer = true;
        timeRemaining = 0;
        dayText.text = ("DAY: " + dayNumber);
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
                dayText.text = ("YOU SURVIVED THE NIGHT!");
                runTimer = false;
                timeRemaining = 0;
                dayNumber++;
                Debug.Log(dayNumber);
                if (dayNumber != 8)
                {
                    changeScenes.LoadNextLevel(4);
                }
                else
                {
                    changeScenes.LoadNextLevel(6);
                }

            }
        }
        timerDisplay.DisplayTime(timeRemaining);
    }
}
