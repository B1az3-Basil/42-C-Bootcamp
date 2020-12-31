using UnityEngine;
using UnityEngine.EventSystems;

public class node_code : MonoBehaviour
{
    public Color node_;
    public Color no_cash;
    public Vector3 off_set;
    [HideInInspector]
    public GameObject turrent;
    [HideInInspector]
    public blue_print turrent_blue;

    [HideInInspector]
    public bool is_upgaded = false;

    private Renderer rer;
    private Color orig;
    public pause_game pause;
   

    void Start()
    {
        rer = GetComponent<Renderer>();
        orig = rer.material.color;
        buildManager = build.ints;
    }

    void OnMouseDown()
    {
     
        if (EventSystem.current.IsPointerOverGameObject())
            return;
       
        if (turrent != null)
        {
            buildManager.select_(this);
            return;
  
        }
        if (!buildManager.can_build)
            return;
        build_turrent(buildManager.get_turrent_to_build());
        
    }

    public void upgarde (){
     
        if (cost.money < turrent_blue.upgade_cost)
        {
            Debug.Log("No cash");
            return;
        }
        cost.money -= turrent_blue.upgade_cost;
        Destroy(turrent);
        GameObject _turrent = (GameObject)Instantiate(turrent_blue.upgarded_prefeb, get_build_position(), Quaternion.identity);
        turrent = _turrent;
        is_upgaded = true;
        GameObject effect_ = (GameObject)Instantiate(buildManager.effect, get_build_position(), Quaternion.identity);
        Destroy(effect_, 5f);
        
        Debug.Log("turrent build upgade");
    }

    public void sell_turr() {
        Destroy(turrent);
        if (is_upgaded == true)
        {
            cost.money += turrent_blue.sell_upgaded;
        }
        else
        {
            cost.money += turrent_blue.sell_normal;
        }
        is_upgaded = false;
        
    }

    void build_turrent(blue_print blue_print_)
    {
        if (cost.money < blue_print_.cost)
        {
            Debug.Log("No cash");
            return;
        }
        cost.money -= blue_print_.cost;
        GameObject _turrent = (GameObject)Instantiate(blue_print_.prefeb, get_build_position(), Quaternion.identity);
        turrent = _turrent;
        FindObjectOfType<sound_manager>().play("Land");
        turrent_blue = blue_print_;
        GameObject effect_ = (GameObject)Instantiate(buildManager.effect, get_build_position(), Quaternion.identity);
        Destroy(effect_, 5f);

        Debug.Log("turrent build, Left:" + cost.money);
    }

    build buildManager;
    public Vector3 get_build_position()
    {
        return transform.position + off_set;
    }
    void OnMouseEnter()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;
        if (!buildManager.can_build)
            return;
        if (buildManager.have_cash)
            rer.material.color = node_;
        else
            rer.material.color = no_cash; 
    }

    void OnMouseExit()
    {
        rer.material.color = orig;
    }
}
