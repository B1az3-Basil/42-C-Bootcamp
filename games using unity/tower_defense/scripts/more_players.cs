using System.ComponentModel.Design.Serialization;
using UnityEngine;
using UnityEngine.UI;

public class more_players : MonoBehaviour
{
   
    public float start_speed = 10f;
    private float speed;
    public float  health = 100;
 
    private Transform target;
    private int index = 0;
    public int gain_more = 50;
    public GameObject death;
    public Image image_health;
 
    void Start()
    {
        speed = start_speed;
        target = turn.points[0];   
    }

    void Change_value(float other)
    {
        image_health.fillAmount = other / 100 * 1;
    }

    public void take_damege(float amount)
    {
        health -= amount;
        Change_value(health);
        if (health <= 0)
            die();
    }

    public void slow(float per)
    {
        speed = start_speed * (1f - per);
    }

    void die()
    {
        cost.money += gain_more;
        GameObject death_eff = (GameObject)Instantiate(death, transform.position, Quaternion.identity);
        Destroy(death_eff, 5f);
        FindObjectOfType<sound_manager>().play("death");
        Destroy(gameObject);
        Debug.Log('a');
        sponer.player_alive--;
    }

    void Update()
    {
      
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
            Get_next_way_points();
        speed = start_speed;
    }

    void Get_next_way_points()
    {
        if (index >= turn.points.Length - 1)
        {
            end_path();
            return;
        }

        index++;
        target = turn.points[index];
    }

    void end_path()
    {
        cost.lives--;
        sponer.player_alive--;
        Destroy(gameObject);
    }
}
