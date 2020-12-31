using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class game_over : MonoBehaviour
{
    public Text rounds_text;
    public fade_in scene;
    public string menu_ = "menu";

    void OnEnable()
    {
        rounds_text.text = cost.rounds.ToString();  
    }

    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        sponer.player_alive = 0;
        scene.fade_to(SceneManager.GetActiveScene().name);
    }

    public void menu()
    {
        scene.fade_to(menu_);
    }
}
