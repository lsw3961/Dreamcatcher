using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeValueChange : MonoBehaviour
{

    public AudioSource aS;
    // Start is called before the first frame update
    void Start()
    {
        aS.volume = .3f;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetVolumeNone()
    {
        aS.volume = 0f;
    }

    public void SetVolumeNormal()
    {
        aS.volume = .5f;
    }

    public void SetVolumeLoud()
    {
        aS.volume = 1f;
    }
}
