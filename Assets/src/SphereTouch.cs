using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SphereTouch : MonoBehaviour
{
    public int sceneToLoad = 2;
    public Material skyBox = null;

    void Update()
    {
        if ((Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began) || Input.GetMouseButtonDown(0))
        {
            Ray ray;
            if (Input.touchCount > 0)
            {
                ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            }
            else
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            }

            RaycastHit Hit;
            if(Physics.Raycast(ray, out Hit))
            {
                if(Hit.transform.gameObject == gameObject)
                {
                    SphereHelper sphereHelper = (SphereHelper)FindObjectOfType(typeof(SphereHelper));
                    sphereHelper.skyBox = skyBox;
                    SceneManager.LoadScene(sceneToLoad);
                }
            }
        }
    }
}
