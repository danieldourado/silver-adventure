using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class SphereEnabledEffect : MonoBehaviour,ITrackableEventHandler
{
    private TrackableBehaviour mTrackableBehaviour;
    void Start()
    {
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
            iTween.ScaleTo(gameObject, iTween.Hash("easeType", "spring", "scale", new Vector3(0.06f, 0.06f, 0.06f),"time", 0.6));
            Debug.Log("Enabled");
        }
    } 
}
    