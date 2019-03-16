using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereHelper : MonoBehaviour
{
    public Material skyBox;
    void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

}
