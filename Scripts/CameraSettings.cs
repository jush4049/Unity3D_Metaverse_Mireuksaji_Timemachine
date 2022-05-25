using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class CameraSettings : MonoBehaviour
{
    public Camera cameraOne; // 플레이어 화면
    public Camera cameraTwo; // 전체 화면(현대)
    public Camera cameraThree; // 전체화면(과거)
    bool Cam = true;

    public Camera EastView;
    public Camera EastView2;
    public Camera WestView;
    public Camera WestView2;
    public Camera PillarView;
    public Camera PillarView2;
    public Camera StoryView;
    public Camera StoryView2;
    public Camera WoodTopView;
    public Camera WeatherCamera;

    public GameObject SubUI;
    public GameObject ViewExitButton;
    public GameObject EastPanel;
    public GameObject WestPanel;
    public GameObject PillarPanel;
    public GameObject MainUI1;
    public GameObject PlayButton;
    public GameObject PlayButton2;
    public GameObject PlayButton3;
    public GameObject PlayButton4;
    public GameObject StopButton;
    public GameObject StopButton2;
    public GameObject StopButton3;
    public GameObject StopButton4;
    public GameObject ResetButton;
    public GameObject ResetButton2;
    public GameObject ResetButton3;
    public GameObject ResetButton4;
    public GameObject StoryUI;
    public GameObject StoryUI2;

    public GameObject myVideo;
    public GameObject myVideo2;
    public GameObject myVideo3;
    public GameObject myVideo4;

    public GameObject EastConvertButton1;
    public GameObject EastConvertButton2;
    public GameObject WestConvertButton1;
    public GameObject WestConvertButton2;
    public GameObject PillarConvertButton1;
    public GameObject PillarConvertButton2;

    public VideoPlayer videoClip;
    public VideoPlayer videoClip2;
    public VideoPlayer videoClip3;
    public VideoPlayer videoClip4;

    public AudioSource Audio;
    public AudioSource MainAudio;
    public AudioClip MainBackgroundMusic; // 메인 씬 배경음악
    public AudioClip StoryBackgroundMusic; // 스토리 배경음악

    public Slider backVolume;

    private float backVol = 1f;

    public GameObject CreditPanel;

    public GameObject Stamp1;
    public GameObject Stamp2;
    public GameObject Stamp3;
    public GameObject Stamp4;
    public GameObject Stamp5;

    public GameObject WeatherMenu;
    public GameObject WeatherMenu2;

    public GameObject MenuButton;
    private void cameraOneOn() //카메라1(플레이어 화면) 키기
    {   
        cameraOne.enabled = true;
        cameraTwo.enabled = false;
        cameraThree.enabled = false;
        EastView.enabled = false;
        EastView2.enabled = false;
        WestView.enabled = false;
        WestView2.enabled = false;
        PillarView.enabled = false;
        PillarView2.enabled = false;
        StoryView.enabled = false;
        StoryView2.enabled = false;
        WoodTopView.enabled = false;
        WeatherCamera.enabled = false;
    }

    private void cameraTwoOn() //카메라2(현대 전체 화면) 키기
    {
        cameraTwo.enabled = true;
        cameraOne.enabled = false;
        cameraThree.enabled = false;
        EastView.enabled = false;
        EastView2.enabled = false;
        WestView.enabled = false;
        WestView2.enabled = false;
        PillarView.enabled = false;
        PillarView2.enabled = false;
        StoryView.enabled = false;
        StoryView2.enabled = false;
        WoodTopView.enabled = false;
        WeatherCamera.enabled = false;
    }

    private void cameraThreeOn() //카메라3(과거 전체 화면) 키기
    {
        cameraThree.enabled = true;
        cameraOne.enabled = false;
        cameraTwo.enabled = false;
        EastView.enabled = false;
        EastView2.enabled = false;
        WestView.enabled = false;
        WestView2.enabled = false;
        PillarView.enabled = false;
        PillarView2.enabled = false;
        StoryView.enabled = false;
        StoryView2.enabled = false;
        WoodTopView.enabled = false;
        WeatherCamera.enabled = false;
    }

    // Start is called before the first frame update
    private void Start()
    {
        MainAudioPlay();

        backVol = PlayerPrefs.GetFloat("backvol", 1f);
        backVolume.value = backVol;
        MainAudio.volume = backVolume.value;

        cameraThree.enabled = false;
        EastView.enabled = false;
        EastView2.enabled = false;
        WestView.enabled = false;
        WestView2.enabled = false;
        PillarView.enabled = false;
        PillarView2.enabled = false;
        StoryView.enabled = false;
        StoryView2.enabled = false;
        WoodTopView.enabled = false;
        WeatherCamera.enabled = false;
        cameraOneOn(); //카메라1 카메라 켜둠

        ViewExitButton.SetActive(false);
        EastPanel.SetActive(false);
        WestPanel.SetActive(false);
        PillarPanel.SetActive(false);

        myVideo.SetActive(false);
        myVideo2.SetActive(false);
        myVideo3.SetActive(false);
        PlayButton.SetActive(false);
        PlayButton2.SetActive(false);
        PlayButton3.SetActive(false);
        StopButton.SetActive(false);
        StopButton2.SetActive(false);
        StopButton3.SetActive(false);
        ResetButton.SetActive(false);
        ResetButton2.SetActive(false);
        ResetButton3.SetActive(false);
        EastConvertButton1.SetActive(false);
        EastConvertButton2.SetActive(false);
        WestConvertButton1.SetActive(false);
        WestConvertButton2.SetActive(false);
        PillarConvertButton1.SetActive(false);
        PillarConvertButton2.SetActive(false);

        StoryUI.SetActive(false);
        StoryUI2.SetActive(false);

        CreditPanel.SetActive(false);
    }

    public void MainAudioPlay()
    {
        this.MainAudio.clip = this.MainBackgroundMusic;
        this.MainAudio.Play();
        this.MainAudio.loop = true;
    }

    public void MainAudioStop()
    {
        this.MainAudio.clip = this.MainBackgroundMusic;
        this.MainAudio.Stop();
    }

    public void MainAudioPause()
    {
        this.MainAudio.clip = this.MainBackgroundMusic;
        this.MainAudio.Pause();
    }

    public void AudioPlay()
    {
        this.Audio.clip = this.StoryBackgroundMusic;
        this.Audio.Play();
        this.Audio.loop = true;
    }

    public void AudioStop()
    {
        this.Audio.clip = this.StoryBackgroundMusic;
        this.Audio.Stop();
    }

    public void AudioPause()
    {
        this.Audio.clip = this.StoryBackgroundMusic;
        this.Audio.Pause();
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

    // Update is called once per frame
    void Update()
    {
        SoundSlider();

        if (Input.GetKeyDown("1")) // 버튼 입력 시 전체 화면 출력
        {
            // 전체 화면 생성 시 UI 제거
            MainUI1.SetActive(false);

            ViewExitButton.SetActive(false);
            EastPanel.SetActive(false);
            WestPanel.SetActive(false);
            PillarPanel.SetActive(false);

            PlayButton.SetActive(false);
            PlayButton2.SetActive(false);
            PlayButton3.SetActive(false);
            StopButton.SetActive(false);
            StopButton2.SetActive(false);
            StopButton3.SetActive(false);
            ResetButton.SetActive(false);
            ResetButton2.SetActive(false);
            ResetButton3.SetActive(false);
            myVideo.SetActive(false);
            myVideo2.SetActive(false);
            myVideo3.SetActive(false);
            OnPauseVideo();
            OnPauseVideo2();
            OnPauseVideo3();
            AudioStop();

            StoryUI.SetActive(false);
            StoryUI2.SetActive(false);

            EastConvertButton1.SetActive(false);
            EastConvertButton2.SetActive(false);
            WestConvertButton1.SetActive(false);
            WestConvertButton2.SetActive(false);
            PillarConvertButton1.SetActive(false);
            PillarConvertButton2.SetActive(false);

            WeatherMenu.SetActive(false);
            WeatherMenu2.SetActive(false);
            if (Cam == true)
            {
                cameraTwoOn();
            }
            else
            {
                /*cameraOneOn();
                cameraThreeOn();*/
                return;
            }
        }

        if (Input.GetKeyDown("2")) // 버튼 입력 시 전체 화면 출력
        {
            // 전체 화면 생성 시 UI 제거
            MainUI1.SetActive(false);

            ViewExitButton.SetActive(false);
            EastPanel.SetActive(false);
            WestPanel.SetActive(false);
            PillarPanel.SetActive(false);

            PlayButton.SetActive(false);
            PlayButton2.SetActive(false);
            PlayButton3.SetActive(false);
            StopButton.SetActive(false);
            StopButton2.SetActive(false);
            StopButton3.SetActive(false);
            ResetButton.SetActive(false);
            ResetButton2.SetActive(false);
            ResetButton3.SetActive(false);
            myVideo.SetActive(false);
            myVideo2.SetActive(false);
            myVideo3.SetActive(false);
            OnPauseVideo();
            OnPauseVideo2();
            OnPauseVideo3();
            AudioStop();

            StoryUI.SetActive(false);
            StoryUI2.SetActive(false);

            EastConvertButton1.SetActive(false);
            EastConvertButton2.SetActive(false);
            WestConvertButton1.SetActive(false);
            WestConvertButton2.SetActive(false);
            PillarConvertButton1.SetActive(false);
            PillarConvertButton2.SetActive(false);

            WeatherMenu.SetActive(false);
            WeatherMenu2.SetActive(false);

            if (Cam == true)
            {
                cameraThreeOn();
            }
            else
            {
                /* cameraOneOn();
                 cameraTwoOn();*/
                return;
            }

        }

        if (Input.GetKeyDown("3")) // 버튼 입력시 플레이어 화면 출력
        {
            // 플레이어 화면 전환 시 UI 생성
            MainUI1.SetActive(true);
            MenuButton.SetActive(true);
            ViewExitButton.SetActive(false);
            EastPanel.SetActive(false);
            WestPanel.SetActive(false);
            PillarPanel.SetActive(false);

            PlayButton.SetActive(false);
            PlayButton2.SetActive(false);
            PlayButton3.SetActive(false);
            StopButton.SetActive(false);
            StopButton2.SetActive(false);
            StopButton3.SetActive(false);
            ResetButton.SetActive(false);
            ResetButton2.SetActive(false);
            ResetButton3.SetActive(false);
            myVideo.SetActive(false);
            myVideo2.SetActive(false);
            myVideo3.SetActive(false);
            OnPauseVideo();
            OnPauseVideo2();
            OnPauseVideo3();
            AudioStop();

            StoryUI.SetActive(false);
            StoryUI2.SetActive(false);

            EastConvertButton1.SetActive(false);
            EastConvertButton2.SetActive(false);
            WestConvertButton1.SetActive(false);
            WestConvertButton2.SetActive(false);
            PillarConvertButton1.SetActive(false);
            PillarConvertButton2.SetActive(false);

            if (Cam == true)
            {
                cameraOneOn();
            }
            else
            {
                /*cameraTwoOn();
                cameraThreeOn();*/
                return;
            }
        }
    }

    public void SoundSlider()
    {
        MainAudio.volume = backVolume.value;

        backVol = backVolume.value;
        PlayerPrefs.SetFloat("backvol", backVol);
    }

    public void EastViewOn()
    {
        EastView.enabled = true;
        WestView.enabled = false;
        PillarView.enabled = false;
        cameraOne.enabled = false;
        StoryView.enabled = false;
        StoryView2.enabled = false;
        WoodTopView.enabled = false;
        MainUI1.SetActive(false);
        EastPanel.SetActive(true);
        ViewExitButton.SetActive(true);
        EastConvertButton1.SetActive(true);
        EastConvertButton2.SetActive(false);

        myVideo.SetActive(true);
        myVideo2.SetActive(false);
        myVideo3.SetActive(false);
        PlayButton.SetActive(true);
        StopButton.SetActive(true);
        ResetButton.SetActive(true);
        PlayButton2.SetActive(false);
        StopButton2.SetActive(false);
        ResetButton2.SetActive(false);
        PlayButton3.SetActive(false);
        StopButton3.SetActive(false);
        ResetButton3.SetActive(false);

        Stamp1.SetActive(true);

        WeatherMenu.SetActive(false);
        WeatherMenu2.SetActive(false);

        MainAudioPause();
    }

    public void EastViewOn2()
    {
        EastView.enabled = false;
        EastView2.enabled = true;
        WestView.enabled = false;
        WestView2.enabled = false;
        PillarView.enabled = false;
        PillarView2.enabled = false;
        cameraOne.enabled = false;
        StoryView.enabled = false;
        StoryView2.enabled = false;
        WoodTopView.enabled = false;
        MainUI1.SetActive(false);
        EastPanel.SetActive(true);
        ViewExitButton.SetActive(true);
        EastConvertButton1.SetActive(false);
        EastConvertButton2.SetActive(true);

        myVideo.SetActive(true);
        myVideo2.SetActive(false);
        myVideo3.SetActive(false);
        PlayButton.SetActive(true);
        StopButton.SetActive(true);
        ResetButton.SetActive(true);
        PlayButton2.SetActive(false);
        StopButton2.SetActive(false);
        ResetButton2.SetActive(false);
        PlayButton3.SetActive(false);
        StopButton3.SetActive(false);
        ResetButton3.SetActive(false);

        WeatherMenu.SetActive(false);
        WeatherMenu2.SetActive(false);

        MainAudioPause();
    }

    public void WestViewOn()
    {
        WestView.enabled = true;
        WestView2.enabled = false;
        EastView.enabled = false;
        EastView2.enabled = false;
        PillarView.enabled = false;
        PillarView2.enabled = false;
        cameraOne.enabled = false;
        StoryView.enabled = false;
        StoryView2.enabled = false;
        WoodTopView.enabled = false;
        MainUI1.SetActive(false);
        WestPanel.SetActive(true);
        ViewExitButton.SetActive(true);
        WestConvertButton1.SetActive(true);
        WestConvertButton2.SetActive(false);

        myVideo2.SetActive(true);
        myVideo.SetActive(false);
        myVideo3.SetActive(false);
        PlayButton2.SetActive(true);
        StopButton2.SetActive(true);
        ResetButton2.SetActive(true);
        PlayButton.SetActive(false);
        StopButton.SetActive(false);
        ResetButton.SetActive(false);
        PlayButton3.SetActive(false);
        StopButton3.SetActive(false);
        ResetButton3.SetActive(false);

        Stamp2.SetActive(true);

        WeatherMenu.SetActive(false);
        WeatherMenu2.SetActive(false);

        MainAudioPause();
    }

    public void WestViewOn2()
    {
        WestView.enabled = false;
        WestView2.enabled = true;
        EastView.enabled = false;
        EastView2.enabled = false;
        PillarView.enabled = false;
        PillarView2.enabled = false;
        cameraOne.enabled = false;
        StoryView.enabled = false;
        StoryView2.enabled = false;
        WoodTopView.enabled = false;
        MainUI1.SetActive(false);
        WestPanel.SetActive(true);
        ViewExitButton.SetActive(true);
        WestConvertButton1.SetActive(false);
        WestConvertButton2.SetActive(true);

        myVideo2.SetActive(true);
        myVideo.SetActive(false);
        myVideo3.SetActive(false);
        PlayButton2.SetActive(true);
        StopButton2.SetActive(true);
        ResetButton2.SetActive(true);
        PlayButton.SetActive(false);
        StopButton.SetActive(false);
        ResetButton.SetActive(false);
        PlayButton3.SetActive(false);
        StopButton3.SetActive(false);
        ResetButton3.SetActive(false);

        WeatherMenu.SetActive(false);
        WeatherMenu2.SetActive(false);

        MainAudioPause();
    }

    public void PillarViewOn()
    {
        PillarView.enabled = true;
        PillarView2.enabled = false;
        WestView.enabled = false;
        WestView2.enabled = false;
        EastView.enabled = false;
        EastView2.enabled = false;
        cameraOne.enabled = false;
        StoryView.enabled = false;
        StoryView2.enabled = false;
        WoodTopView.enabled = false;
        MainUI1.SetActive(false);
        PillarPanel.SetActive(true);
        ViewExitButton.SetActive(true);
        PillarConvertButton1.SetActive(true);
        PillarConvertButton2.SetActive(false);

        myVideo3.SetActive(true);
        myVideo.SetActive(false);
        myVideo2.SetActive(false);
        PlayButton3.SetActive(true);
        StopButton3.SetActive(true);
        ResetButton3.SetActive(true);
        PlayButton2.SetActive(false);
        StopButton2.SetActive(false);
        ResetButton2.SetActive(false);
        PlayButton.SetActive(false);
        StopButton.SetActive(false);
        ResetButton.SetActive(false);

        Stamp3.SetActive(true);

        WeatherMenu.SetActive(false);
        WeatherMenu2.SetActive(false);

        MainAudioPause();
    }

    public void PillarViewOn2()
    {
        PillarView.enabled = false;
        PillarView2.enabled = true;
        WestView.enabled = false;
        WestView2.enabled = false;
        EastView.enabled = false;
        EastView2.enabled = false;
        cameraOne.enabled = false;
        StoryView.enabled = false;
        StoryView2.enabled = false;
        WoodTopView.enabled = false;
        MainUI1.SetActive(false);
        PillarPanel.SetActive(true);
        ViewExitButton.SetActive(true);
        PillarConvertButton1.SetActive(false);
        PillarConvertButton2.SetActive(true);

        myVideo3.SetActive(true);
        myVideo.SetActive(false);
        myVideo2.SetActive(false);
        PlayButton3.SetActive(true);
        StopButton3.SetActive(true);
        ResetButton3.SetActive(true);
        PlayButton2.SetActive(false);
        StopButton2.SetActive(false);
        ResetButton2.SetActive(false);
        PlayButton.SetActive(false);
        StopButton.SetActive(false);
        ResetButton.SetActive(false);

        WeatherMenu.SetActive(false);
        WeatherMenu2.SetActive(false);

        MainAudioPause();
    }

    public void WoodTopViewOn()
    {
        PillarView.enabled = false;
        WestView.enabled = false;
        EastView.enabled = false;
        cameraOne.enabled = false;
        cameraOne.enabled = false;
        StoryView.enabled = false;
        StoryView2.enabled = false;
        WoodTopView.enabled = true;
        MainUI1.SetActive(false);
        ViewExitButton.SetActive(true);

        CreditPanel.SetActive(true);
        MainAudioPause();
    }

    public void MainViewOn()
        {
            cameraOneOn();
            MainUI1.SetActive(true);
            EastPanel.SetActive(false);
            WestPanel.SetActive(false);
            PillarPanel.SetActive(false);
            ViewExitButton.SetActive(false);

            PlayButton.SetActive(false);
            PlayButton2.SetActive(false);
            PlayButton3.SetActive(false);
            StopButton.SetActive(false);
            StopButton2.SetActive(false);
            StopButton3.SetActive(false);
            ResetButton.SetActive(false);
            ResetButton2.SetActive(false);
            ResetButton3.SetActive(false);
            myVideo.SetActive(false);
            myVideo2.SetActive(false);
            myVideo3.SetActive(false);
            OnPauseVideo();
            OnPauseVideo2();
            OnPauseVideo3();
            AudioStop();

            StoryUI2.SetActive(false);
            StoryUI.SetActive(false);

        EastConvertButton1.SetActive(false);
        EastConvertButton2.SetActive(false);
        WestConvertButton1.SetActive(false);
        WestConvertButton2.SetActive(false);
        PillarConvertButton1.SetActive(false);
        PillarConvertButton2.SetActive(false);

        CreditPanel.SetActive(false);
    }

    public void StoryViewOn()
        {
            StoryView.enabled = true;
            StoryView2.enabled = false;
            PillarView.enabled = false;
            WestView.enabled = false;
            EastView.enabled = false;
            PillarView2.enabled = false;
            WestView2.enabled = false;
            EastView2.enabled = false;
            cameraOne.enabled = false;
            WoodTopView.enabled = false;
            MainUI1.SetActive(false);
            StoryUI2.SetActive(false);
            StoryUI.SetActive(true);

            Stamp4.SetActive(true);

        MainAudioPause();
    }

    public void StoryViewOn2()
    {
        StoryView2.enabled = true;
        StoryView.enabled = false;
        PillarView.enabled = false;
        WestView.enabled = false;
        EastView.enabled = false;
        PillarView2.enabled = false;
        WestView2.enabled = false;
        EastView2.enabled = false;
        cameraOne.enabled = false;
        WoodTopView.enabled = false;
        MainUI1.SetActive(false);

        StoryUI.SetActive(false);
        StoryUI2.SetActive(true);

        Stamp5.SetActive(true);

        MainAudioPause();
    }
}
