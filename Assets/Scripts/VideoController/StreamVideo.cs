using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class StreamVideo : MonoBehaviour
{
    private RequestURL uRLs;
    private RawImage rawImage;

    private VideoPlayer videoPlayer;
    private VideoSource videoSource;

    private AudioSource audioSource;

    private void Start()
    {
        uRLs = this.gameObject.GetComponent<RequestURL>();
        rawImage = this.gameObject.GetComponent<RawImage>();
        uRLs.Reset();
        uRLs.Ex_Request();
        StartCoroutine(PlayVideo());
    }

    IEnumerator PlayVideo()
    {
        videoPlayer = gameObject.AddComponent<VideoPlayer>();
        audioSource = gameObject.AddComponent<AudioSource>();

        videoPlayer.playOnAwake = false;
        audioSource.playOnAwake = false;

        videoPlayer.isLooping = true;

        videoPlayer.source = VideoSource.Url;

        videoPlayer.url = uRLs.I_Request(URLController.i);

        //URLController.ActiveVideo(URLController.i);

        //Debug.Log(URLController.i);

        if(URLController.i == 9)
        {
               uRLs.Reset();
               URLController.i = 0;
        }

        videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;

        videoPlayer.EnableAudioTrack(0, true);
        videoPlayer.SetTargetAudioSource(0, audioSource);

        videoPlayer.Prepare();

        WaitForSeconds waitForSeconds = new WaitForSeconds(1);

        while (!videoPlayer.isPrepared)
        {
            yield return waitForSeconds;
            break;
        }

        rawImage.texture = videoPlayer.texture;

        while(this.gameObject.tag != "active")
        {
            yield return null;
        }

        videoPlayer.Play();
        audioSource.Play();

        while (videoPlayer.isPlaying)
        {
            yield return null;

        }
    }

}
