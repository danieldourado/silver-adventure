using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SphereTouch : MonoBehaviour
{
    // Start is called before the first frame update
    public int sceneToLoad = 2;
    void Start()
    {
        
    }

    // Update is called once per frame
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
                string btnName = Hit.transform.name;
                switch(btnName)
                {
                    case "Sphere1":
                        SceneManager.LoadScene(2);
                        break;
                    case "Sphere2":
                        SceneManager.LoadScene(3);
                        break;
                    case "Sphere3":
                        SceneManager.LoadScene(4);
                        break;
                }
            }
        }
    }
}
