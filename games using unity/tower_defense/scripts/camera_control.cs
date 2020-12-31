using UnityEngine;

public class camera_control : MonoBehaviour
{
    private bool do_somethng = true;
    public float pan_speed = 30f;
    public float Thickness = 10f;

    // Update is called once per frame
    void Update()
    {
        if (game_manager.game_ended)
        {
            this.enabled = false;
            return;
        }
            
        if (Input.GetKeyDown(KeyCode.Escape))
            do_somethng = !do_somethng;
        if (!do_somethng)
            return;

        if (Input.GetKey("w") || Input.mousePosition.y >= Screen.height - Thickness )
            transform.Translate(Vector3.forward  * pan_speed * Time.deltaTime,Space.World);
        if (Input.GetKey("s") || Input.mousePosition.y <= Thickness)
            transform.Translate(Vector3.back * pan_speed * Time.deltaTime, Space.World);
        else if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - Thickness)
            transform.Translate(Vector3.right * pan_speed * Time.deltaTime, Space.World);
        if (Input.GetKey("a") || Input.mousePosition.x <= Thickness)
            transform.Translate(Vector3.left * pan_speed * Time.deltaTime, Space.World);
    }
}
