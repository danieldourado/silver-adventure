using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VideoEnablerWhenDetected : MonoBehaviour, ITrackableEventHandler
{
    private TrackableBehaviour mTrackableBehaviour;
    private UnityEngine.Video.VideoPlayer videoPlayer;
    void Start()
    {
        mTrackableBehaviour = transform.parent.GetComponent<TrackableBehaviour>();
        videoPlayer = transform.GetComponent<UnityEngine.Video.VideoPlayer>();
        videoPlayer.Stop();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }
    public void OnTrackableStateChanged(
                                    TrackableBehaviour.Status previousStatus,
                                    TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            videoPlayer.Stop();
            videoPlayer.Play();
        }
        if (newStatus == TrackableBehaviour.Status.NO_POSE)
        {
            videoPlayer.Stop();
        }
    }
}
