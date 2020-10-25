using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseGameScript : MonoBehaviour
{
    public int health;
    public ChangeScene changeSceneScript;
    public int sceneChange;
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(health);
        health--;
        if (health <= 0)
        {
            changeSceneScript.MoveScenes(sceneChange);
        }
    }
}
