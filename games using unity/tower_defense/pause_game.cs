using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Video;

public class pause_game : MonoBehaviour
{
    [HideInInspector]
    public bool pause = false;
    public GameObject shop;
    [HideInInspector]
    public GameObject pause_meun_;
    
   
    public static pause_game intt;
    

  void Awake()
    {
        intt = this;
    }
    // Update is called once per frame
    void Update()
    {
        if (game_manager.game_ended == true || paused_menu.quit == true)
            return;
        if (pause == false)
        {
            if (Input.GetKeyDown("space"))
            {
                pause_();
            }
        }
        else
        {
            if (Input.GetKeyDown("space"))
            {
                resume();
            }
        }
     
    }
    public void resume()
    {
        Time.timeScale = 1f;
        shop.SetActive(true);
        pause_meun_.SetActive(false);
        pause = false;
    }

    public void pause_() {
        Time.timeScale = 0f;
        shop.SetActive(false);
        pause_meun_.SetActive(true);
        pause = true;

    }
}
