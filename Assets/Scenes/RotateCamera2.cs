using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera2 : MonoBehaviour
{
    public bool gyroEnabled = false;
    private Gyroscope gyro;

    public GameObject cameraContainer;
    private Quaternion rot;

    void Start()
    {
        cameraContainer = new GameObject("Camera Container");
        cameraContainer.transform.position = transform.position;
        TouchRotateCamera tc  = cameraContainer.AddComponent<TouchRotateCamera>() as TouchRotateCamera;
        transform.SetParent(cameraContainer.transform);

        gyroEnabled = EnableGyro();
    }

    private bool EnableGyro()
    {
        if(SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;

            cameraContainer.transform.localRotation = Quaternion.Euler(90f, 90f, 0f);
            rot = new Quaternion(0, 0, 1, 0);

            return true;
        }

        return false;
    }
    // Update is called once per frame
    void Update()
    {
        if(gyroEnabled)
        {
            transform.localRotation = gyro.attitude * rot;
        }
    }
}
