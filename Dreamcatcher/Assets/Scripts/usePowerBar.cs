using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class usePowerBar : MonoBehaviour
{

    public ScoreKeeping scoreKeeper;
    public EnemySpawning spawner;
    public int playerScore;
    public GameObject PowerBar;
    public GameObject flashOfLight;
    public bool runTimer;
    public float timer;
    public float timerConstant;
    void Start()
    {
        PowerBar.SetActive(false);
        flashOfLight.SetActive(false);
    }
    void Update()
    {
        Debug.Log(playerScore);
        playerScore = scoreKeeper.ScoreforPower;
        if (playerScore >= 150)
        {
            PowerBar.SetActive(true);
        }
        if (playerScore >= 150 && Input.GetKeyDown(KeyCode.Space))
        {
            PowerBar.SetActive(false);
            flashOfLight.SetActive(true);
            runTimer = true;
            for (int i = 0;i<spawner.enemies.Count;i++)
            {
                Destroy(spawner.enemies[i]);
                spawner.CreateNew(spawner.enemies[i]);

            }
            playerScore = 0;
            scoreKeeper.ResetScore();
        }
        if (runTimer)
        {
            if (timer >= 0)
            {
                timer -= Time.deltaTime;
            }
            else
            {
                runTimer = false;
                timer = timerConstant;
                flashOfLight.SetActive(false);
            }
        }
    }
}
