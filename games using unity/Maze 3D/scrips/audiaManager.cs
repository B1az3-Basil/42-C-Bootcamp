using System;
using UnityEngine;

public class audiaManager : MonoBehaviour
{
    public soundsvv[] Sounds;
   

  
    // Start is called before the first frame update
    void Awake()
    {
        foreach(soundsvv s in Sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.sound;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.Loop;
        }
    }
    public void playSound(string nameOfSounds)
    {
        soundsvv s = Array.Find(Sounds, sounds => sounds.nameOfSound == nameOfSounds);

        if (s == null)
        {
            Debug.LogError("the sound doesn't match:(");
            return;
        }
        s.source.Play();  
    }

}
