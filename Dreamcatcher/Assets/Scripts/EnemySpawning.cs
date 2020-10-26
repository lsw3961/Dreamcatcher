using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawning : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera cam;
    float height;
    float width;
    public List<GameObject> enemies;
    public List<GameObject> prefabs;
    public ScoreKeeping scoreKeeper;
    public DiffcultyMeter meter;
    Vector3 position;
    public int numberOfGhosts;
    void Start()
    {
        height = 2f * cam.orthographicSize;
        width = height * cam.aspect;
        for (int i = 0; i < meter.DifficutlyPerDay(); i++)
        {
            int positionDecider = Random.Range(1, 8);
            switch (positionDecider)
            {
                    //top right
                case (1):
                    position = new Vector3(Random.Range(0, 10f), Random.Range(5,5.5f));
                    enemies.Add(Instantiate(prefabs[Random.Range(0, prefabs.Count)], position, Quaternion.identity));
                    break;
                    //right top
                case (2):
                    position = new Vector3(Random.Range(10f, 10.5f), Random.Range(0, 5f));
                    enemies.Add(Instantiate(prefabs[Random.Range(0, prefabs.Count)], position, Quaternion.identity));
                    break;
                    //bottom right
                case (3):
                    position = new Vector3(Random.Range(0, 10f), Random.Range(-5.5f, -5f));
                    enemies.Add(Instantiate(prefabs[Random.Range(0, prefabs.Count)], position, Quaternion.identity));
                    break;
                    //left top
                case (4):
                    position = new Vector3(Random.Range(-10f, -10.5f), Random.Range(0, 5f));
                    enemies.Add(Instantiate(prefabs[Random.Range(0, prefabs.Count)], position, Quaternion.identity));
                    enemies[i].GetComponent<SpriteRenderer>().flipX = true;
                    break;
                //top left
                case (5):
                    position = new Vector3(Random.Range(-10f,0), Random.Range(5, 5.5f));
                    enemies.Add(Instantiate(prefabs[Random.Range(0, prefabs.Count)], position, Quaternion.identity));
                    enemies[i].GetComponent<SpriteRenderer>().flipX = true;
                    break;
                //right bottom
                case (6):
                    position = new Vector3(Random.Range(10f, 10.5f), Random.Range(-5.5f, 0));
                    enemies.Add(Instantiate(prefabs[Random.Range(0, prefabs.Count)], position, Quaternion.identity));
                    break;
                //bottom left
                case (7):
                    position = new Vector3(Random.Range(-10f, 0f), Random.Range(-5.5f, -5f));
                    enemies.Add(Instantiate(prefabs[Random.Range(0, prefabs.Count)], position, Quaternion.identity));
                    enemies[i].GetComponent<SpriteRenderer>().flipX = true;

                    break;
                //left bottom
                case (8):
                    position = new Vector3(Random.Range(-10f, -10.5f), Random.Range(-5.5f,0));
                    enemies.Add(Instantiate(prefabs[Random.Range(0, prefabs.Count)], position, Quaternion.identity));
                    enemies[i].GetComponent<SpriteRenderer>().flipX = true;
                    break;
            }
            

        }
        //Debug.Log(enemies.Count);
    }
    public void CreateNew(GameObject removed)
    {
        enemies.Remove(removed);
        scoreKeeper.updateScore();
        int positionDecider = Random.Range(1, 8);
        switch (positionDecider)
        {
            //top right
            case (1):
                position = new Vector3(Random.Range(0, 10f), Random.Range(5, 5.5f));
                enemies.Add(Instantiate(prefabs[Random.Range(0, prefabs.Count)], position, Quaternion.identity));
                break;
            //right top
            case (2):
                position = new Vector3(Random.Range(10f, 10.5f), Random.Range(0, 5f));
                enemies.Add(Instantiate(prefabs[Random.Range(0, prefabs.Count)], position, Quaternion.identity));
                break;
            //bottom right
            case (3):
                position = new Vector3(Random.Range(0, 10f), Random.Range(-5.5f, -5f));
                enemies.Add(Instantiate(prefabs[Random.Range(0, prefabs.Count)], position, Quaternion.identity));
                break;
            //left top
            case (4):
                position = new Vector3(Random.Range(-10f, -10.5f), Random.Range(0, 5f));
                enemies.Add(Instantiate(prefabs[Random.Range(0, prefabs.Count)], position, Quaternion.identity));
                enemies[enemies.Count - 1].GetComponent<SpriteRenderer>().flipX = true;
                break;
            //top left
            case (5):
                position = new Vector3(Random.Range(-10f, 0), Random.Range(5, 5.5f));
                enemies.Add(Instantiate(prefabs[Random.Range(0, prefabs.Count)], position, Quaternion.identity));
                enemies[enemies.Count - 1].GetComponent<SpriteRenderer>().flipX = true;
                break;
            //right bottom
            case (6):
                position = new Vector3(Random.Range(10f, 10.5f), Random.Range(-5.5f, 0));
                enemies.Add(Instantiate(prefabs[Random.Range(0, prefabs.Count)], position, Quaternion.identity));
                break;
            //bottom left
            case (7):
                position = new Vector3(Random.Range(-10f, 0f), Random.Range(-5.5f, -5f));
                enemies.Add(Instantiate(prefabs[Random.Range(0, prefabs.Count)], position, Quaternion.identity));
                enemies[enemies.Count - 1].GetComponent<SpriteRenderer>().flipX = true;

                break;
            //left bottom
            case (8):
                position = new Vector3(Random.Range(-10f, -10.5f), Random.Range(-5.5f, 0));
                enemies.Add(Instantiate(prefabs[Random.Range(0, prefabs.Count)], position, Quaternion.identity));
                enemies[enemies.Count - 1].GetComponent<SpriteRenderer>().flipX = true;
                break;
        }
    }

}




//enemies[enemies.Count - 1].GetComponent<SpriteRenderer>().flipY = true;