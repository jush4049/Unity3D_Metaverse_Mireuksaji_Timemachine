using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject Menu;
    public GameObject MenuButton;
    public GameObject Guide;
    public GameObject Guide2;
    public GameObject DisconncectMenu;
    public GameObject Settings;
    public GameObject CharacterMenu;
    public GameObject CreditMenu;
    public GameObject StampMenu;
    public GameObject WeatherMenu;
    public GameObject WeatherMenu2;

    public GameObject Stamp1;
    public GameObject Stamp2;
    public GameObject Stamp3;
    public GameObject Stamp4;
    public GameObject Stamp5;
    public GameObject Stamp6;

    public Camera WeatherCamera;
    // Start is called before the first frame update
    void Start()
    {
        WeatherCamera.enabled = false;
        MenuButton.SetActive(true);
        Menu.SetActive(false);
        Guide.SetActive(false);
        Guide2.SetActive(false);
        DisconncectMenu.SetActive(false);
        Settings.SetActive(false);
        CharacterMenu.SetActive(false);
        CreditMenu.SetActive(false);
        StampMenu.SetActive(false);
        WeatherMenu.SetActive(false);
        WeatherMenu2.SetActive(false);

        Stamp1.SetActive(false);
        Stamp2.SetActive(false);
        Stamp3.SetActive(false);
        Stamp4.SetActive(false);
        Stamp5.SetActive(false);
        Stamp6.SetActive(false);
    }
    public void MenuOn() // 클릭 시 메뉴1 패널 생성
    {
        Menu.SetActive(true);
    }
    public void MenuOff() // 클릭 시 메뉴1 패널 제거
    {
        Menu.SetActive(false);
    }
    public void GuideOn() // 클릭 시 가이드 패널 생성
    {
        Guide.SetActive(true);
    }
    public void GuideOff() // 클릭 시 가이드 패널 제거
    {
        Guide.SetActive(false);
    }
    public void GuideOn2() // 클릭 시 가이드 패널 생성
    {
        Guide2.SetActive(true);
    }
    public void GuideOff2() // 클릭 시 가이드 패널 제거
    {
        Guide2.SetActive(false);
    }
    public void DisconncetMenuOn() // 클릭 시 종료 패널 생성
    {
        DisconncectMenu.SetActive(true);
    }
    public void DisconncetMenuOff() // 클릭 시 종료 패널 제거
    {
        DisconncectMenu.SetActive(false);
    }
    public void SettingsMenuOn() // 클릭 시 설정 패널 생성
    {
        Settings.SetActive(true);
    }
    public void SettingsMenuOff() // 클릭 시 설정 패널 제거
    {
        Settings.SetActive(false);
    }
    public void CharacterMenuOn() // 클릭 시 캐릭터 패널 생성
    {
        CharacterMenu.SetActive(true);
    }
    public void CharacterMenuOff() // 클릭 시 캐릭터 패널 제거
    {
        CharacterMenu.SetActive(false);
    }
    public void CreditMenuOn() // 클릭 시 크레딧 패널 생성
    {
        CreditMenu.SetActive(true);
    }   
    public void CreditMenuOff() // 클릭 시 크레딧 패널 제거
    {
        CreditMenu.SetActive(false);
    }
    public void StampMenuOn() // 클릭 시 스탬프 패널 생성
    {
        StampMenu.SetActive(true);
    }
    public void StampMenuOff() // 클릭 시 스탬프 패널 제거
    {
        StampMenu.SetActive(false);
    }
    public void WeatherMenuOn() // 클릭 시 날씨 패널 생성
    {
        WeatherCamera.enabled = true;
        WeatherMenu.SetActive(true);
        WeatherMenu2.SetActive(false);
        Menu.SetActive(false);
        MenuButton.SetActive(false);
        Stamp6.SetActive(true);
        //MenuButton.SetActive(false);
    }
    public void WeatherMenuOff() // 클릭 시 날씨 패널 제거
    {
        WeatherCamera.enabled = false;
        WeatherMenu.SetActive(false);
        WeatherMenu2.SetActive(false);
        Menu.SetActive(true);
        MenuButton.SetActive(true);
        //MenuButton.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
