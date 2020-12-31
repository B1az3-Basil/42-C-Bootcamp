using UnityEngine;

public class next_level : MonoBehaviour
{
    //public GameObject finished;
    public ui ui;
    public scoreNumber ScoreNumber;
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "player")
        {
            ui.enableContinue();
            ui.endGame = true;
        }  
    }
}
