using System.Diagnostics;
using UnityEngine;

public class players_movement : MonoBehaviour
{
    public ui ui;
    public buttons Buttons;
    public CharacterController controller;
    public float speed = 6f;
    public float turn_smooth_time = 0.1f;
    public Joystick joystickLeft;
    public Joystick joystickRight;
    float turn_smooth;
    public Transform cam;
    float horizontal;
    float vertical;

    void Update()
    {
        
        if (ui.unlock == true)
            return;
        if (Buttons.leftRight == false)
        {
            horizontal = joystickLeft.Horizontal;
            vertical = joystickLeft.Vertical;
        }
        else
        {
            horizontal = joystickRight.Horizontal;
            vertical = joystickRight.Vertical;
        }
        Vector3 dir = new Vector3(horizontal, 0f, vertical).normalized;

        if (dir.magnitude >= 0.1f)
        {
            float target = Mathf.Atan2(dir.x, dir.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, target, ref turn_smooth, turn_smooth_time);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            Vector3 move_dir = Quaternion.Euler(0f, target, 0f) * Vector3.forward;
            controller.Move(move_dir.normalized * speed * Time.deltaTime);
        }
    }
}
    


