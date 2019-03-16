using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SphereTouch : MonoBehaviour
{
    public int sceneToLoad = 0;
    public Material skyBox = null;

    private void Awake() => DontDestroyOnLoad(transform.gameObject);
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
                SceneManager.LoadScene(sceneToLoad);
                SphereController sphereController = (SphereController)FindObjectOfType(typeof(SphereController));
                sphereController.gameObject.SendMessage("SetSkybox", skyBox);

                Destroy(this);
            }
        }
    }
}
