using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    EnemySpawning spawner;
    public float lifeTime;
    public int soundNum = 0;

    [SerializeField]
    GameObject death1;

    [SerializeField]
    GameObject death2;

    [SerializeField]
    GameObject death3;


    private Shake shake;
    void Start()
    {
        GameObject temp = GameObject.FindGameObjectWithTag("Spawner");
        //Debug.Log(temp);
        spawner = temp.GetComponent<EnemySpawning>();
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Shake>();
        soundNum = Random.Range(0, 6);
    }
    void OnMouseOver()
    {
        lifeTime -= Time.deltaTime;

        if (lifeTime < 0)
        {
            shake.camshake();
            spawner.CreateNew(gameObject);

            

            Destroy(gameObject);

            if (soundNum == 1)
            {
                death1.GetComponent<AudioSource>().PlayOneShot(death1.GetComponent<AudioSource>().clip, .5f);
            }
            else if (soundNum == 2)
            {
                death2.GetComponent<AudioSource>().PlayOneShot(death2.GetComponent<AudioSource>().clip, .5f);
            }
            else
            {
                death3.GetComponent<AudioSource>().PlayOneShot(death3.GetComponent<AudioSource>().clip, .5f);
            }
        }
    }
}
