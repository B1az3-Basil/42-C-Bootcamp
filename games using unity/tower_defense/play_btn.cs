using UnityEngine;
using UnityEngine.SceneManagement;

public class play_btn : MonoBehaviour
{

    public string level_load = "main";

    public void start_game() {
        paused_menu.quit = false;
        FindObjectOfType<fade_in>().fade_to(level_load);   
    }

    public void quit() {
        Application.Quit();
    }

}
