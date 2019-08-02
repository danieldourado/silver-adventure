using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class CanvasControl : MonoBehaviour
{
    public List<Button> buttons;
    public List<GameObject> screens;
    public Vuforia.VuforiaBehaviour vuforiaBehaviour;

    private void Start()
    {
        GoTo360();
    }

    public void GoToInicio()
    {
        SceneManager.LoadScene(0);
    }

    public void GoTo360()
    {
        DisableAllScreens(screens);
        vuforiaBehaviour.enabled = true;
    }

    public void GoToAgencias()
    {
        DisableAllScreens(screens);
        GameObject.FindObjectOfType<GoogleMapsMinimalDemo>().Show();
    }

    public void SetButtoClicked(Button button)
    {
        SetAllButtonsUnclicked(buttons);
        button.GetComponent<Image>().color = new Color(0, 0.5f, 1);
    }

    void SetAllButtonsUnclicked(List<Button> buttons)
    {
        foreach(Button button in buttons)
        {
            button.GetComponent<Image>().color = new Color(0, 0, 0);
        }
    }

    public void EnableScreen(GameObject screen)
    {
        DisableAllScreens(screens);
        screen.SetActive(true);
    }

    public void DisableAllScreens(List<GameObject> screens)
    {
        foreach(GameObject screen in screens)
        {
            screen.SetActive(false);
        }
        vuforiaBehaviour.enabled = false;
        GameObject.FindObjectOfType<GoogleMapsMinimalDemo>().Hide();
    }
}
