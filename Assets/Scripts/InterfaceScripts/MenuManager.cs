using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{


    public GameObject ShopPan;
    public GameObject SettingsPan;
    public GameObject ServerCamera;
    public GameObject RoomCamera;
    public GameObject UpgradeBtnServer;

    public GameObject EnabledSound;
    public GameObject DisabledSound;

    public GameObject UpdateServerPan;
    public GameObject EnabledMusic;
    public GameObject DisabledMusic;

    public GameObject RusLang;
    public GameObject EngLang;

    public GameObject ServersBtn;
    public GameObject ShopBtn;
    public GameObject HomeBtn;
    public GameObject TelephonBtn;

    [SerializeField] private GameObject MissionTel;
    void Start()
    {
        
    }

    void Update()
    {
        if(ShopPan.activeInHierarchy == true)
        {
            MissionTel.SetActive(false);
            SettingsPan.SetActive(false);
        }

        if(MissionTel.activeInHierarchy == true)
        {
            ShopPan.SetActive(false);
            SettingsPan.SetActive(false);
        }
        
        if(SettingsPan.activeInHierarchy == true)
        {
            MissionTel.SetActive(false);
            ShopPan.SetActive(false);
        }


        if(ServerCamera.activeInHierarchy == false)
        {
            ServersBtn.SetActive(true);
            HomeBtn.SetActive(false);
            ShopBtn.SetActive(true);
            TelephonBtn.SetActive(true);
        }
        else if(ServerCamera.activeInHierarchy == true)
        {
            ServersBtn.SetActive(false);
            HomeBtn.SetActive(true);
            ShopBtn.SetActive(false);
            TelephonBtn.SetActive(false);
        }
    }
    public void ShopEnable() { //Включение и выключение магазина

        ShopPan.SetActive(!ShopPan.activeSelf);
        SettingsPan.SetActive(false);
    }

    public void SwitchServers_Rooms() { // Переключение серверной комнаты

        ServerCamera.SetActive(!ServerCamera.activeSelf);
        UpdateServerPan.SetActive(!UpdateServerPan.activeSelf);
        UpgradeBtnServer.SetActive(!UpgradeBtnServer.activeSelf);
    }
    public void SettingsEnable() {

        SettingsPan.SetActive(true);
        ShopPan.SetActive(false);
    }
    public void QuitSettingsPan()
    {
        SettingsPan.SetActive(false);

    }
    public void SwitchLanguage() {
        RusLang.SetActive(!RusLang.activeSelf);
        EngLang.SetActive(!EngLang.activeSelf);
    }

    public void EnableDisableSound() {
        EnabledSound.SetActive(!EnabledSound.activeSelf);
        DisabledSound.SetActive(!DisabledSound.activeSelf);
    }
    public void EnableDisableMusic() {
        EnabledMusic.SetActive(!EnabledMusic.activeSelf);
        DisabledMusic.SetActive(!DisabledMusic.activeSelf);
    }
    public void WorkEnable()//Телефон с заказами
    {
        if(MissionTel.activeSelf)
        {
            MissionTel.SetActive(false);
        }
        else
        {
            MissionTel.SetActive(true);
        }
    }

    public void BackHome()
    {
        ServerCamera.SetActive(false);
    }
}
