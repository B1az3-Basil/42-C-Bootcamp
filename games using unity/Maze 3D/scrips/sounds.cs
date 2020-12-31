using UnityEngine;
[System.Serializable]
public class soundsvv 
{
    public string nameOfSound;
    public bool Loop;
    public AudioClip sound;
    [Range(0, 1f)]
    public float volume;
    [Range(.1f, 2f)]
    public float pitch;
    [HideInInspector]
    public AudioSource source;
}
