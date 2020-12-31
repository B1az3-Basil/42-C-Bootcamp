using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Networking.NetworkSystem;

public class sponer : MonoBehaviour
{
    public static int player_alive = 0;
    public wave_player[] players;
    
    public Transform loc;
    public float real_count_between = 20f;
    public float count_down = 2f;
    public Text count_;
    private int wave_ = 0;
    bool play_ = true;
    bool ree = true;



    void Update()
    {
        if (ree == false)
        {
            play_ = true;
            return;
        }
           
        if (player_alive > 0)
        {
            Debug.Log("number added:" + player_alive);
            return;
        }
        if (count_down <= 0f)
        {
            StartCoroutine(spawn_new());
            count_down = real_count_between;
           
            return;
        }
        count_down -= Time.deltaTime;
        count_down = Mathf.Clamp(count_down, 0f, Mathf.Infinity);
        count_.text = string.Format("{0:00.00}",count_down);

        if (count_down < 3.5 && play_)
        {
            FindObjectOfType<sound_manager>().play("RespawnCount");
            play_ = !play_;
        }
    }

    IEnumerator spawn_new()
    {
        cost.rounds++;
        wave_player wave = players[wave_];
        for (int i = 0; i < wave.count; i++)
        {
            spawn_other(wave.players);
            yield return new WaitForSeconds(1f / wave.rate);
            if (i == wave.count - 1)
                ree = true;
            else
                ree = false;
        }
        wave_++;

        if (wave_ == players.Length)
        {
            this.enabled = false;
        }
    }

    void spawn_other(GameObject play)
    {
        Instantiate(play,loc.position, loc.rotation);
        player_alive++;
       
        FindObjectOfType<sound_manager>().play("Spawn");
     
    }
}
