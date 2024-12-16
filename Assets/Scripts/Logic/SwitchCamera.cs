using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SwitchCamera : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    public int manager = 1;

    public InputActionReference SwitchCameraBtn;

    // Start is called before the first frame update
    void Start()
    {
        cam1.SetActive(true);
        cam2.SetActive(false);

        SwitchCameraBtn.action.started += ButtonWasPressed;
        SwitchCameraBtn.action.canceled += ButtonWasReleased;
    }

    void ButtonWasPressed(InputAction.CallbackContext context)
    {
        ManageCamera();
    }

    void ButtonWasReleased(InputAction.CallbackContext context)
    {
        manager *= -1;
        ManageCamera();
    }

    void ManageCamera()
    {
        if (manager == 1)
        {
            Camera1();
        }
        else if (manager == -1) 
        {
            Camera2();
        }
    }

    void Camera1()
    {
        cam1.SetActive(true);
        cam2.SetActive(false);
    }

    void Camera2()
    {
        cam1.SetActive(false);
        cam2.SetActive(true);
    }
}
