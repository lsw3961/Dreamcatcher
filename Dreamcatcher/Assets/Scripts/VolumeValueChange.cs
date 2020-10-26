using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeValueChange : MonoBehaviour
{
    private AudioSource audioSrc;

    private float musicVolume = 1f;
    // Start is called before the first frame update
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        Debug.Log(audioSrc);
    }

    // Update is called once per frame
    void Update()
    {
        audioSrc.volume = musicVolume;
        Debug.Log(audioSrc.volume);
    }

    public void SetVolume(float vol)
    {
        musicVolume = vol;
    }
}
