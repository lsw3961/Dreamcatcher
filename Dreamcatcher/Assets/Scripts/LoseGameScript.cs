using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LoseGameScript : MonoBehaviour
{
    public int health;
    EnemySpawning spawner;
    public SceneTransitionLoading sceneManager;
    public int SceneIndex;
    public Text healthText;
    public void Start()
    {
        GameObject temp = GameObject.FindGameObjectWithTag("Spawner");
        //Debug.Log(temp);
        spawner = temp.GetComponent<EnemySpawning>();
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(health);
        spawner.CreateNew(collision.gameObject);
        Destroy(collision.gameObject);
        health--;
        if (health <= 0)
        {
            sceneManager.LoadNextLevel(SceneIndex);
        }
    }
    public void Update()
    {
        healthText.text = health.ToString();
    }
}
