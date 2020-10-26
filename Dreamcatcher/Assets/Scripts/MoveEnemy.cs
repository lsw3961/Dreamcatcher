using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    [SerializeField]
    float speed;
    Vector3 position;
    Vector3 target;
    /// <summary>
    /// start function
    /// </summary>
    void Start()
    {
        target = new Vector3(0, 0, 0);
        position = gameObject.transform.position;
    }
    /// <summary>
    /// update function
    /// </summary>
    void FixedUpdate()
    {
        BasicMovement();
    }

    /// <summary>
    /// basic movement for all enemies, other methods can be used in conjunction to alter the path of the enemy
    /// </summary>
    public void BasicMovement()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target, step);
    }
}
