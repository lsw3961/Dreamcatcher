using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ScoreKeeping : MonoBehaviour
{
    public Text score;
    public int scoreValue;
    static int currentScore;
    int sceneNum;


    public void Start()
    {
        sceneNum = SceneManager.GetActiveScene().buildIndex;
        if (sceneNum == 1)
        {
            currentScore = 0;
        }
        else
            printScore();
    }
    public void updateScore()
    {
        Debug.Log(currentScore);
        currentScore += scoreValue;
        score.text = "Score: " + currentScore;
    }
    public void printScore()
    {
        score.text = "Score: " + currentScore;
    }
    



}
