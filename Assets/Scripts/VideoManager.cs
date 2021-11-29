Using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{

    private VideoPlayer videoPlayer;

    // Use this for initialization
    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }

    public void Play()
    {
        videoPlayer.Play();
    }

    public void Pause()
    {
        videoPlayer.Pause();
    }

    public void Stop()
    {
        videoPlayer.Stop();
    }
}
