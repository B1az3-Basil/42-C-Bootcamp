using UnityEngine;
[System.Serializable]
public class saveSettings
{
  
    public bool change;

    public saveSettings(buttons score)
    {
        change = score.leftRight;
    }
}
