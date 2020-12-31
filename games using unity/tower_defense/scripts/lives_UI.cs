using UnityEngine;
using UnityEngine.UI;

public class lives_UI : MonoBehaviour
{
    public Text lives;
   // Update is called once per frame
    void Update()
    {
        lives.text = cost.lives + " LIVES";
        
    }
}
