using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RegisterNewPlayer : MonoBehaviour
{
    public string InputName;
    public GameObject inputField;
    int ReadyRegister;
    int ChoosedAvatar;
    int HavingAvatar = 0;
    private void Start()
    {
        
        ChoosedAvatar = PlayerPrefs.GetInt("IdAvatar");
        InputName = PlayerPrefs.GetString("PlayerName");
        HavingAvatar = PlayerPrefs.GetInt("checkAvatar");
        ReadyRegister = PlayerPrefs.GetInt("FullRegister");

        Debug.Log(InputName);

        if(ReadyRegister == 1 && HavingAvatar == 1)  //Проверка игрока, зареган ли он или нет
        {
            SceneManager.LoadScene(1); // Переход игрока в основную сцену если он зареган
        }
      

    }   
    private void Update()
    {
        
    }


    public void EnterName() // Ввод и сохранение имени игрока
    {
        InputName = inputField.GetComponent<Text>().text; 
        PlayerPrefs.SetString("PlayerName", InputName); //Сохранение данных
        ReadyRegister = 1; // Регистрация игрока готова
        PlayerPrefs.SetInt("FullRegister", ReadyRegister);
        if(HavingAvatar == 1 && HavingAvatar == 1)
        {
            SceneManager.LoadScene(1);
        }
        
    }



    public void ChooseAvatar1() // Выбор первого аватара
    {
        ChoosedAvatar = 1;
        HavingAvatar = 1;
        PlayerPrefs.SetInt("checkAvatar", HavingAvatar);
        PlayerPrefs.SetInt("IdAvatar", ChoosedAvatar);
    }

    public void ChooseAvatar2() // Выбор второга аватара
    {
        ChoosedAvatar = 2;
        HavingAvatar = 1;
        PlayerPrefs.SetInt("checkAvatar", HavingAvatar);
        PlayerPrefs.SetInt("IdAvatar", ChoosedAvatar);
    }

    public void ChooseAvatar3() // Выбор третьего аватара
    {
        ChoosedAvatar = 3;
        HavingAvatar = 1;
        PlayerPrefs.SetInt("checkAvatar", HavingAvatar);
        PlayerPrefs.SetInt("IdAvatar", ChoosedAvatar);
    }
    public void ChooseAvatar4()
    {
        ChoosedAvatar = 4;
        HavingAvatar = 1;
        PlayerPrefs.SetInt("checkAvatar", HavingAvatar);
        PlayerPrefs.SetInt("IdAvatar", ChoosedAvatar);
    }
    public void ChooseAvatar5()
    {
        ChoosedAvatar = 5;
        HavingAvatar = 1;
        PlayerPrefs.SetInt("checkAvatar", HavingAvatar);
        PlayerPrefs.SetInt("IdAvatar", ChoosedAvatar);
    }
    public void ChooseAvatar6()
    {
        ChoosedAvatar = 6;
        HavingAvatar = 1;
        PlayerPrefs.SetInt("checkAvatar", HavingAvatar);
        PlayerPrefs.SetInt("IdAvatar", ChoosedAvatar);
    }
}
