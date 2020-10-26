using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateMusicGame : MonoBehaviour
{
    [SerializeField]
    GameObject musicGame;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(musicGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
