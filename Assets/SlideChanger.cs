using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class SlideChanger : MonoBehaviour, IPointerClickHandler 
{
    public List<Sprite> sprites;
    public int timeToWait = 3;
    private Image image;
    private bool canClick = false;
    void Start()
    {
        image = gameObject.GetComponent<Image>();
        StartCoroutine(WaitForSeconds());
    }

    IEnumerator WaitForSeconds()
    {
        yield return new WaitForSeconds(timeToWait);
        ChangeImage();
        canClick = true;
    }


    private void ChangeImage()
    {
        image.overrideSprite = sprites[0];
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!canClick) return;
        SceneManager.LoadScene(1);
    }
}
