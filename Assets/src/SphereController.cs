using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetSkybox(Material skyboxMaterial)
    {
        RenderSettings.skybox = skyboxMaterial;
    }
}
