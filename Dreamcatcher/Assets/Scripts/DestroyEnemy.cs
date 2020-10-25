using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    EnemySpawning spawner;
    public float lifeTime;

    void Start()
    {
        GameObject temp = GameObject.FindGameObjectWithTag("Spawner");
        Debug.Log(temp);
        spawner = temp.GetComponent<EnemySpawning>();
    }
    void OnMouseOver()
    {
        lifeTime -= Time.deltaTime;

        if (lifeTime < 0)
        {
            spawner.CreateNew(gameObject);
            Destroy(gameObject);
        }
    }
}
