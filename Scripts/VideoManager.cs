using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{
    public GameObject myVideo;
    public GameObject myVideo2;
    public GameObject myVideo3;
    public GameObject myVideo4;
    public VideoPlayer videoClip;
    public VideoPlayer videoClip2;
    public VideoPlayer videoClip3;
    public VideoPlayer videoClip4;

    public void OnPlayVideo()
    {
        myVideo.SetActive(true);
        videoClip.Play();
    }
    public void OnPlayVideo2()
    {
        myVideo2.SetActive(true);
        videoClip2.Play();
    }
    public void OnPlayVideo3()
    {
        myVideo3.SetActive(true);
        videoClip3.Play();
    }
    public void OnPlayVideo4()
    {
        myVideo4.SetActive(true);
        videoClip4.Play();
    }

    public void OnPauseVideo()
    {
        myVideo.SetActive(false);
        videoClip.Pause();
    }
    public void OnPauseVideo2()
    {
        myVideo2.SetActive(false);
        videoClip2.Pause();
    }
    public void OnPauseVideo3()
    {
        myVideo3.SetActive(false);
        videoClip3.Pause();
    }
    public void OnPauseVideo4()
    {
        myVideo4.SetActive(false);
        videoClip4.Pause();
    }
    public void OnResetVideo()
    {
        videoClip.time = 0f;
        videoClip.playbackSpeed = 1f;
    }
    public void OnResetVideo2()
    {
        videoClip2.time = 0f;
        videoClip2.playbackSpeed = 1f;
    }
    public void OnResetVideo3()
    {
        videoClip3.time = 0f;
        videoClip3.playbackSpeed = 1f;
    }
    public void OnResetVideo4()
    {
        videoClip4.time = 0f;
        videoClip4.playbackSpeed = 1f;
    }
    public void OnFastVideo(float speed)
    {
        videoClip.playbackSpeed = speed;
    }
}