using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public AudioSource BackgroundAudio;

    //default volume
    private float musicVolume = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        BackgroundAudio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        BackgroundAudio.volume = musicVolume;
    }

    public void updateVolume(float volume)
    {
        musicVolume = volume;
    }
}
