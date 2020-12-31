using UnityEngine;
using UnityEngine.UI;

public class scoreNumber : MonoBehaviour
{
    public Text scoreNum;
    public Text highestScoreNum;
    public ui ui;
    [HideInInspector]
    public int numberLevels = 1;
    [HideInInspector]
    public int highestScore;
    private int temp;


    private void Awake()
    {
        playersData data = saveSystem.loadSaved();
        temp = data.highScore;
    }

    public void textChange(int score)
    {
    
        scoreNum.text = score.ToString();
        if (score <= temp)
        {
            highestScore = temp;
            diplay();
            return;
        }
        highestScore = score;
        diplay();
        save();
    }

    public void save()
    {
        saveSystem.saveInfo(this);
    }
    void diplay()
    {
        highestScoreNum.text = highestScore.ToString();
    }
    
}
