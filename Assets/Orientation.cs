using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Orientation : MonoBehaviour
{
    public GameObject voltarButton;
    public GameObject helperUI;

    void Awake()
    {
        Input.compass.enabled = true;
        Input.gyro.enabled = true;
        Input.location.Start();
        Input.compensateSensors = true;
    }

    public void Enter360()
    {
        if (CanEnter360(Input.deviceOrientation))
        {
            GetComponent<GyroscopeCameraRotation>().enabled = true;
            GetComponent<TouchCameraRotation>().enabled = true;
            voltarButton.SetActive(true);
        }
    }

    bool CanEnter360(DeviceOrientation orientation)
    {
        if (orientation == DeviceOrientation.FaceUp) return false;
        if (orientation == DeviceOrientation.FaceDown) return false;
        return true;
    }
}