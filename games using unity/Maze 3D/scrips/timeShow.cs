using UnityEngine;

public class timeShow : MonoBehaviour
{
    //[HideInInspector]
    public static float time = 5f;
    float num;
    public GameObject playersCamera;
    public GameObject playersCam;
    // Update is called once per frame
    void Update()
    {
        if (time <= 0)
        {
           num = Random.Range(0, 2);
           time = 5f;
        }
       
        time -= Time.deltaTime;
        if (num <= 0.5)
        {
            playersCamera.SetActive(true);
            playersCam.SetActive(false);
        }
        else
        {
            playersCamera.SetActive(false);
            playersCam.SetActive(true);
        }
            
    }
}
