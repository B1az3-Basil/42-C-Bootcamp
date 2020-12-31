using UnityEngine;
using UnityEngine.UI;

public class settings : MonoBehaviour
{
    public buttons Buttons;
    public Text move;
    public Text cameraC;

    private void Update()
    {
        if (Buttons.leftRight == true)
        {
            move.text = "CAMERA";
            cameraC.text = "MOVE";
     
        }
        else
        {
            cameraC.text = "CAMERA";
            move.text = "MOVE";
 
        }
    }

}
