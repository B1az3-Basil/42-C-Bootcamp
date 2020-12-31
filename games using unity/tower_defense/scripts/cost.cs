using UnityEngine;

public class cost : MonoBehaviour
{
    public static int money;
    public int start_money = 400;
    public static int lives;
    public int start_live = 20;
    public static int rounds;
     void Start()
    {
        rounds = 0;
        lives = start_live;
        money = start_money;   
    }

}
