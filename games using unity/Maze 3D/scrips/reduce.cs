using UnityEngine;

public class reduce : MonoBehaviour
{
    public ui ui;
    public AudioSource Audio;

    // Update is called once per frame
    void Update()
    {
        if (ui.gamePaused == true)
        {
            Audio.volume = .5f;
        }
        else
        {
            Audio.volume = 1;
        }
    }
}
