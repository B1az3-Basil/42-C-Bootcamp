using System;
using UnityEngine;
using UnityEngine.UI;

public class ui : MonoBehaviour
{
    public Image timerBar;
    public GameObject Timer_GO;
    public GameObject timerGO;
    public GameObject pauseMenu;
    public GameObject uiGameObject;
    public GameObject continueToNextLevel;
    public GameObject failedCanvas;
    public scoreNumber ScoreNumber;
    public int levelToUnlock = 2;
    [HideInInspector]
    public static bool endGame = false;
    [HideInInspector]
    public bool gamePaused = false;
    [HideInInspector]
    public static int score;
    public Text timer;
    public float timeSolveMaze = 600f;
    public float countDown = 3f;
    [HideInInspector]
    public bool unlock = true;
    [HideInInspector]
    public bool callOnce = false;
    private bool played = false;

    // Update is called once per frame

  
    void Update()
    {
        if (countDown <= 0)
        {
            countDown = timeSolveMaze;
            if (unlock == false)
            {
                failedCanvas.SetActive(true);
       
                return;

            }

            timerGO.SetActive(true);
            Timer_GO.SetActive(false);
            unlock = false;
         
        }   
        if (endGame == false)
        {
            countDown -= Time.deltaTime;
            countDown = Mathf.Clamp(countDown, 0f, Mathf.Infinity);
            timer.text = string.Format("{0:0.00}", countDown);
          
        }
         else
      {
          // for now
          if (callOnce == false)
            {
                callOnce = true;
                score = Convert.ToInt32(countDown * 2);
                ScoreNumber.textChange(score);
              

                if (played == false)
                {
                    PlayerPrefs.SetInt("completedLevel", levelToUnlock);
                    Debug.Log(levelToUnlock);
                    played = true;
                  
                }
            }
      
        }
        if (unlock == false)
        {
            timerBar.fillAmount = countDown / timeSolveMaze;
           
        }
    }

    public void disableGameobject()
    {
        gamePaused = true;
        pauseMenu.SetActive(true);
        uiGameObject.SetActive(false);
    }
    public void enableGameobject()
    {
        gamePaused = false;
        pauseMenu.SetActive(false);
        uiGameObject.SetActive(true);
    }

    public void enableContinue()
    {
        uiGameObject.SetActive(false);
        continueToNextLevel.SetActive(true);
    } 

}
