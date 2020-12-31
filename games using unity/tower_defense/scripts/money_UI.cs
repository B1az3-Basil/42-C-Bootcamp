using UnityEngine;
using UnityEngine.UI;

public class money_UI : MonoBehaviour
{
    public Text money_text;
    // Update is called once per frame
    void Update()
    {
        money_text.text = "R" + cost.money.ToString();
    }
}
