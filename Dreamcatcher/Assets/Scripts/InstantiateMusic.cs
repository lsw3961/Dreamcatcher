using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateMusic : MonoBehaviour
{
    [SerializeField]
    GameObject musicPlayer;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(musicPlayer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
