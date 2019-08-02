using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitApplication : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
    }
    public void GoBack()
    {
        SceneManager.LoadScene(0);
    }

}
