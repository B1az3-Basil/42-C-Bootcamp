﻿using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class sound 
{
    public string name;
    public AudioClip clip;
    [Range(0, 1f)]
    public float volume;
    [Range(.1f, 3f)]
    public float pitch;
    [HideInInspector]
    public AudioSource source;
}
