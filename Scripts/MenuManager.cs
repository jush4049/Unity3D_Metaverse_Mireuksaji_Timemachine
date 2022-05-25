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
    public void MenuOn() // Ŭ�� �� �޴�1 �г� ����
    {
        Menu.SetActive(true);
    }
    public void MenuOff() // Ŭ�� �� �޴�1 �г� ����
    {
        Menu.SetActive(false);
    }
    public void GuideOn() // Ŭ�� �� ���̵� �г� ����
    {
        Guide.SetActive(true);
    }
    public void GuideOff() // Ŭ�� �� ���̵� �г� ����
    {
        Guide.SetActive(false);
    }
    public void GuideOn2() // Ŭ�� �� ���̵� �г� ����
    {
        Guide2.SetActive(true);
    }
    public void GuideOff2() // Ŭ�� �� ���̵� �г� ����
    {
        Guide2.SetActive(false);
    }
    public void DisconncetMenuOn() // Ŭ�� �� ���� �г� ����
    {
        DisconncectMenu.SetActive(true);
    }
    public void DisconncetMenuOff() // Ŭ�� �� ���� �г� ����
    {
        DisconncectMenu.SetActive(false);
    }
    public void SettingsMenuOn() // Ŭ�� �� ���� �г� ����
    {
        Settings.SetActive(true);
    }
    public void SettingsMenuOff() // Ŭ�� �� ���� �г� ����
    {
        Settings.SetActive(false);
    }
    public void CharacterMenuOn() // Ŭ�� �� ĳ���� �г� ����
    {
        CharacterMenu.SetActive(true);
    }
    public void CharacterMenuOff() // Ŭ�� �� ĳ���� �г� ����
    {
        CharacterMenu.SetActive(false);
    }
    public void CreditMenuOn() // Ŭ�� �� ũ���� �г� ����
    {
        CreditMenu.SetActive(true);
    }   
    public void CreditMenuOff() // Ŭ�� �� ũ���� �г� ����
    {
        CreditMenu.SetActive(false);
    }
    public void StampMenuOn() // Ŭ�� �� ������ �г� ����
    {
        StampMenu.SetActive(true);
    }
    public void StampMenuOff() // Ŭ�� �� ������ �г� ����
    {
        StampMenu.SetActive(false);
    }
    public void WeatherMenuOn() // Ŭ�� �� ���� �г� ����
    {
        WeatherCamera.enabled = true;
        WeatherMenu.SetActive(true);
        WeatherMenu2.SetActive(false);
        Menu.SetActive(false);
        MenuButton.SetActive(false);
        Stamp6.SetActive(true);
        //MenuButton.SetActive(false);
    }
    public void WeatherMenuOff() // Ŭ�� �� ���� �г� ����
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
