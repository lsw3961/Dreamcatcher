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
    Vector3 position;
    public int numberOfGhosts;
    void Start()
    {
        height = 2f * cam.orthographicSize;
        width = height * cam.aspect;
        for (int i = 0; i < enemies.Count; i++)
        {
            int positionDecider = Random.Range(1, 4);
            switch (positionDecider)
            {
                    //top
                case (1):
                    position = new Vector3(Random.Range(-10f, 10f), Random.Range(5,5.5f));
                    break;
                    //right
                case (2):
                    position = new Vector3(Random.Range(10f, 10.5f), Random.Range(-5f, 5f));
                    break;
                    //bottom
                case (3):
                    position = new Vector3(Random.Range(-10f, 10f), Random.Range(-5.5f, -5f));

                    break;
                    //left
                case (4):
                    position = new Vector3(Random.Range(10f, 10.5f), Random.Range(-5.5f, -5f));

                    break;
            }
            
            enemies.Add(Instantiate(prefabs[Random.Range(0, prefabs.Count)], position, Quaternion.identity));
        }
        //Debug.Log(enemies.Count);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log(enemies.Count);
        if (enemies.Count < numberOfGhosts)
        {
            int positionDecider = Random.Range(1, 4);
            switch (positionDecider)
            {
                //top
                case (1):
                    position = new Vector3(Random.Range(-10f, 10f), Random.Range(5.5f, 5f));
                    break;
                //right
                case (2):
                    position = new Vector3(Random.Range(10f, 10.5f), Random.Range(5f, 5.5f));
                    break;
                //bottom
                case (3):
                    position = new Vector3(Random.Range(-10f, 10f), Random.Range(-5.5f, -5f));

                    break;
                //left
                case (4):
                    position = new Vector3(Random.Range(10f, 10.5f), Random.Range(-5.5f, -5f));

                    break;
            }
            enemies.Add(Instantiate(prefabs[Random.Range(0, prefabs.Count)], position, Quaternion.identity));
        }
    }

}
