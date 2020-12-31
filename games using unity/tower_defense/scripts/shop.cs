using UnityEngine;

public class shop : MonoBehaviour
{
    public blue_print turr;
    public blue_print turr_missile;
    public blue_print turr_laser;
    build buildManager;

    void Start()
    {
        buildManager = build.ints;
    }


    public void purchase()
    {
        Debug.Log("ready");
        buildManager.select(turr);
    }
    public void purchase_other_missile()
    {
        buildManager.select(turr_missile);
    }

    public void purchase_laser()
    {
        buildManager.select(turr_laser);
    }
}
