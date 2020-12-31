using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class camera_movement : MonoBehaviour
{

    public ui ui;
    public buttons Buttons;
    public Joystick joystickRight;
    public Joystick joystickLeft;
    public Transform Player;
    public Transform spotLight;
    public float MouseSensitivity = 100f;
    float xRotation = 0f;
    float yRotation = 0f;
    float mouseY;
    float mouseX;
    public Text touchTest;
    public Vector2 mousePosition;
    


    // Update is called once per frame
    void Update()
    {
 
        if (ui.unlock == true)
            return;
        if (Buttons.leftRight == false)
        {
             mouseX = joystickRight.Horizontal * MouseSensitivity * Time.deltaTime;
             mouseY = joystickRight.Vertical * MouseSensitivity * Time.deltaTime;
        }
        else 
        {
            mouseX = joystickLeft.Horizontal * MouseSensitivity * Time.deltaTime;
            mouseY = joystickLeft.Vertical * MouseSensitivity * Time.deltaTime;
        }


     
        xRotation -= mouseY;
        yRotation += mouseX;
        xRotation = Mathf.Clamp(xRotation, -45f, 45f);

        transform.localRotation = Quaternion.Euler(xRotation, yRotation , 0f);
        Player.Rotate(Vector3.up * mouseX);
        spotLight.rotation = transform.rotation;

    }
}
