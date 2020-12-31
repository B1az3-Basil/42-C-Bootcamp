using UnityEngine;
using UnityEngine.SceneManagement;

public class game_manager : MonoBehaviour
{
    public static bool game_ended;
    public GameObject game_over_ui;
    public bool game_over;
    
   // Update is called once per frame
   void Start()
    {
        game_ended = false;
    }
    void Update()
    {
        if (game_ended)
            return;
        if (cost.lives <= 0)
            end_game();
    }

    void end_game()
    {
        game_ended = true;
        game_over_ui.SetActive(true);
        game_over = game_ended;
        FindObjectOfType<sound_manager>().play("GameOver");
    }
}
