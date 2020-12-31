using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static float showMapTime = 7f;
    public buttons map;
    // Update is called once per frame
    void Update()
    {
        if (showMapTime <= 0)
            map.mapPanel.SetActive(false);
        showMapTime -= Time.deltaTime;
    }
}
