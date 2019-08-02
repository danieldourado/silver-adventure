using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class GameobjectChanger : MonoBehaviour
{
    public List<GameObject> gameObjects;
    public int timeToWait = 3;
    void Start()
    {
        EnableGameobject(gameObjects, 0);
        StartCoroutine(WaitForSeconds());
    }
    IEnumerator WaitForSeconds()
    {
        yield return new WaitForSeconds(timeToWait);
        EnableGameobject(gameObjects, 1);
    }
    public void EnableGameObject(GameObject go)
    {
        EnableGameobject(gameObjects, gameObjects.IndexOf(go));
    }
    private void EnableGameobject(List<GameObject> gos, int indexToBeEnabled)
    {
        DeactivateAllGameobjects(gos);
        gos[indexToBeEnabled].SetActive(true);
    }
    void DeactivateAllGameobjects(List<GameObject> goList)
    {
        foreach (GameObject go in goList)
        {
            go.SetActive(false);
        }
    }
}
