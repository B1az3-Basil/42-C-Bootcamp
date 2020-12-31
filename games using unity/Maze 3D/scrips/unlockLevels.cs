using UnityEngine.UI;
using UnityEngine;

public class unlockLevels : MonoBehaviour
{
    public Button[] button;
    private int i = 0;
    // Start is called before the first frame update
    void Awake()
    {
        int completedLevel = PlayerPrefs.GetInt("completedLevel", 1);
       while (i < button.Length)
        {
            if (i + 1 > completedLevel)
            {
                button[i].interactable = false;
            }
            i++;
        } 
    }
}
