using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ScoreKeeping : MonoBehaviour
{
    public int scoreValue;
    public static int currentScore;
    public int ScoreforPower;
    int sceneNum;


    public void Start()
    {
        sceneNum = SceneManager.GetActiveScene().buildIndex;
        if (sceneNum == 1)
        {
            currentScore = 0;
        }
    }
    public void updateScore()
    {
        Debug.Log(currentScore);
        currentScore += scoreValue;
        ScoreforPower = currentScore;
    }

    public void ResetScore()
    {
        currentScore = 0;
        ScoreforPower = 0;
    }



}
