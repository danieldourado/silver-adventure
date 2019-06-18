using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VideoEnablerWhenDetected : MonoBehaviour, ITrackableEventHandler
{
    GameObject imageHelper;
    private TrackableBehaviour mTrackableBehaviour;
    private UnityEngine.Video.VideoPlayer videoPlayer;

    void Awake()
    {
        imageHelper = GameObject.FindObjectOfType<HelperImage>().gameObject;
    }
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
            imageHelper.SetActive(false);
            StartCoroutine(Show());
        }
        if (newStatus == TrackableBehaviour.Status.NO_POSE)
        {
            videoPlayer.Stop();
            imageHelper.SetActive(true);
            StartCoroutine(Hide());
        }
        else
            onTrackingLost();
    }

    private void onTrackingLost()
    {
        
    }
    IEnumerator Show()
    {
        yield return new WaitForSeconds(0.5f);
        imageHelper.SetActive(false);
    }
    IEnumerator Hide()
    {
        yield return new WaitForSeconds(0.5f);
        imageHelper.SetActive(true);
    }
}
