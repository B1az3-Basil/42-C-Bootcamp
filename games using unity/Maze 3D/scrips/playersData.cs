using UnityEngine;
[System.Serializable]
public class playersData 
{
    public int highScore;
    public bool change;

    public playersData(scoreNumber score)
    {
        highScore = score.highestScore;
    }
}
