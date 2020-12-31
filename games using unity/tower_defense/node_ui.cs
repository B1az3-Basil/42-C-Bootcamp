
using UnityEngine;
using UnityEngine.UI;

public class node_ui : MonoBehaviour
{
    public GameObject ui;
    private node_code target;
    public Button upgade_btn;
    public Text upgade_cost;
    

    public void Set_target(node_code _target)
    {
        target = _target;
        transform.position = target.get_build_position();

        if (!target.is_upgaded)
        {
            upgade_cost.text = "R" + target.turrent_blue.upgade_cost;
            upgade_btn.interactable = true;
        }
        else
        {
            upgade_cost.text = "DONE";
            upgade_btn.interactable = false;
        }

            

        ui.SetActive(true);

    }
    public void hide()
    {
        ui.SetActive(false);
    }

    public void upgade()
    {
        target.upgarde();
        build.ints.deselect_node();
     
    }

    public void sell()
    {
        target.sell_turr();
        build.ints.deselect_node();

    }
}
