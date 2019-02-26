using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SphereTouch : MonoBehaviour
{
    // Start is called before the first frame update
    string btnName;
    public int sceneToGo = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
        Debug.Log("test");
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            if(Physics.Raycast(ray, out Hit))
            {
                btnName = Hit.transform.name;
                switch(btnName)
                {
                    case "Sphere1":
                        SceneManager.LoadScene(1);
                        break;
                    case "Sphere2":
                        SceneManager.LoadScene(2);
                        break;
                    case "Sphere3":
                        SceneManager.LoadScene(3);
                        break;
                }
            }
        }
    }
}
