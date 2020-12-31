using UnityEditor.Experimental.GraphView;
using UnityEngine; 
using UnityEngine.Analytics;

public class build : MonoBehaviour
{
    public static build ints;
    private GameObject turrent;

    void Awake()
    {
        ints = this;
    }

    
    public GameObject effect;
    public node_ui ui;
    private blue_print turrent_to_build;
    private node_code selected_node;
    public void select_(node_code node)
    {
        if (selected_node == node)
        {
            deselect_node();
            return;
        }
           
        selected_node = node;
        turrent_to_build = null;
        ui.Set_target(node);
    }

    public void deselect_node()
    {
        selected_node = null;
            ui.hide();
    }
   
    public void select(blue_print turrent)
    {
      
        turrent_to_build = turrent;
        selected_node = null;
        ui.hide();  
    }
    public bool have_cash
    {
        get
        {
            return cost.money >= turrent_to_build.cost;
        }
    }
    public bool can_build 
    { 
        get 
        { 
            return turrent_to_build != null; 
        } 
    }
    public blue_print get_turrent_to_build()
    {
        return turrent_to_build;
    }
  
   
   
}