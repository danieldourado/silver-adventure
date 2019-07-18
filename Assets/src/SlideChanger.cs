using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class SlideChanger : MonoBehaviour, IPointerClickHandler
{
    public GameObject buttons;
    public List<Sprite> sprites;
    public int timeToWait = 3;
    private Image image;
    private bool canClick = false;
    void Start()
    {
        buttons.SetActive(false);
        image = gameObject.GetComponent<Image>();
        StartCoroutine(WaitForSeconds());
    }
    IEnumerator WaitForSeconds()
    {
        yield return new WaitForSeconds(timeToWait);
        ChangeImage();
    }
    private void ChangeImage()
    {
        image.overrideSprite = sprites[0];
        buttons.SetActive(true);
    }
    public void ShowInstruction()
    {
        image.overrideSprite = sprites[1];
        buttons.SetActive(false);
        canClick = true;
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (!canClick) return;
        SceneManager.LoadScene(1);
    }
}
