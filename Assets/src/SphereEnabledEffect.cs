using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class SphereEnabledEffect : MonoBehaviour,ITrackableEventHandler
{
    GameObject imageHelper;
    private TrackableBehaviour mTrackableBehaviour;
    public float targetSize = 0.06f;
    public float time = 0.6f;
    void Start()
    {
        imageHelper = GameObject.FindObjectOfType<HelperImage>().gameObject;
        mTrackableBehaviour = transform.parent.GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }

    void OnEnable()
    {
    }
    public void OnTrackableStateChanged(
                                    TrackableBehaviour.Status previousStatus,
                                    TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            transform.localScale = new Vector3(0,0,0);
            iTween.ScaleTo(gameObject, iTween.Hash("easeType", "spring", "scale", new Vector3(targetSize, targetSize, targetSize),"time", time));
            Debug.Log("Enabled");
            imageHelper.SetActive(false);
        }
        else
            onTrackingLost();
    }

    private void onTrackingLost()
    {
        imageHelper.SetActive(true);
    }
}
    