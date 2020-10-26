using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiffcultyMeter : MonoBehaviour
{
    public int day;
    public CountdownTimerScript timer;
    public List<int> enemyNumberPerDay;
    // Start is called before the first frame update
    void Start()
    {
        day = timer.DayNumber;

    }
    public int DifficutlyPerDay()
    {
        switch (day)
        {
            case (1):
                return enemyNumberPerDay[0];

                break;
            case (2):
                return enemyNumberPerDay[1];

                break;
            case (3):
                return enemyNumberPerDay[2];

                break;
            case (4):
                return enemyNumberPerDay[3];

                break;
            case (5):
                return enemyNumberPerDay[4];

                break;
            case (6):
                return enemyNumberPerDay[5];

                break;
            case (7):
                return enemyNumberPerDay[6];
                break;
        }
        return enemyNumberPerDay[0];
    }
}
