using UnityEngine.SceneManagement;
using UnityEngine;
using System;

public class paused_menu : MonoBehaviour
{
    public static bool quit;
   
    public GameObject check_person;
    public fade_in fade;
    public string menu = "menu";

    public void resume()
    {
        pause_game.intt.resume();
    }
   
    public void no()
    {
        check_person.SetActive(false);
        quit = false;
        Debug.Log("no");
    }
    public void yes()
    {
        fade.fade_to(menu);
        Time.timeScale = 1f;
    }
    public void exit() {
        check_person.SetActive(true);
        quit = true;
        Debug.Log("ac");
    }

    public void restart() {
        fade.fade_to(SceneManager.GetActiveScene().name);
        pause_game.intt.resume();
    }
}
