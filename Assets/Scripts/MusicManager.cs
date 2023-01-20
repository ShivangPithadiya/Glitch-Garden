using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioClip[] levelMusicChangeArray;
    private AudioSource audiosource;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnLevelWasLoaded(int level)
    {
        AudioClip thisLevelMusic = levelMusicChangeArray[level];
        if (thisLevelMusic)
        {
            audiosource.clip = thisLevelMusic;
            audiosource.loop = true;
            audiosource.Play();
        }
    }

    internal void SetVolume(float value)
    {
        audiosource.volume = value;
    }
}
