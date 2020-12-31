using UnityEngine;
using UnityEngine.UI;

public class disableNotInUse : MonoBehaviour
{
    public GameObject mainMenu;
    public float countDown = 120f;
    public Text message;
    // Update is called once per frame

    private void Start()
    {
        FindObjectOfType<audiaManager>().playSound("mainMenu");
    }
    void Update()
    {
        if (countDown <= 0)
        {
            mainMenu.SetActive(false);
            message.text = "TAP TO CONTINUE...";
        }
        countDown -= Time.deltaTime;

        if (Input.touchCount > 0)
        {
            mainMenu.SetActive(true);
            countDown = 120f;
            message.text = "";
            Debug.Log("mouse");
        }
    }
}
