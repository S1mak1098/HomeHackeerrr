using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchRoom : MonoBehaviour
{

    public GameObject OrdersPan;
    public GameObject RoomCam01;
    public GameObject RoomCam02;
    public GameObject RoomCam03;

    public GameObject pcCamera_Room1;
    public GameObject pcCamera_Room2;
    public GameObject pcCamera_Room3;

    int ChoosedRooms;
    private void Start()
    {
        ChoosedRooms = PlayerPrefs.GetInt("AllRooms");

        if(ChoosedRooms == 1) {

            RoomCam01.SetActive(true);
            RoomCam02.SetActive(false);
            RoomCam03.SetActive(false);
        }

        if(ChoosedRooms == 2) {

            RoomCam01.SetActive(false);
            RoomCam02.SetActive(true);
            RoomCam03.SetActive(false);
        }

        if(ChoosedRooms == 3) {

            RoomCam01.SetActive(false);
            RoomCam02.SetActive(false);
            RoomCam03.SetActive(true);
        }
    }


    private void Update()
    {

    }

    public void FirstRoomBtn() {

        ChoosedRooms = 1;
        PlayerPrefs.SetInt("AllRooms", ChoosedRooms);
        RoomCam01.SetActive(true);
        RoomCam02.SetActive(false);
        RoomCam03.SetActive(false);

        pcCamera_Room1.SetActive(false);
        pcCamera_Room2.SetActive(false);
        pcCamera_Room3.SetActive(false);
    }

    public void SecondRoomBtn() {
    
        ChoosedRooms = 2;
        PlayerPrefs.SetInt("AllRooms", ChoosedRooms);
        RoomCam01.SetActive(false);
        RoomCam02.SetActive(true);
        RoomCam03.SetActive(false);

        pcCamera_Room1.SetActive(false);
        pcCamera_Room2.SetActive(false);
        pcCamera_Room3.SetActive(false);
    }

    public void ThirdRoomBtn() {

        ChoosedRooms = 3;
        PlayerPrefs.SetInt("AllRooms", ChoosedRooms);
        RoomCam01.SetActive(false);
        RoomCam02.SetActive(false);
        RoomCam03.SetActive(true);

        pcCamera_Room1.SetActive(false);
        pcCamera_Room2.SetActive(false);
        pcCamera_Room3.SetActive(false);
    }

    public void EnablePC() {

        OrdersPan.SetActive(false);
        if(ChoosedRooms == 1){
            pcCamera_Room1.SetActive(true);
        }
        if(ChoosedRooms == 2){
            pcCamera_Room2.SetActive(true);
        }
        if(ChoosedRooms == 3){
            pcCamera_Room3.SetActive(true);
        }
    }
}
