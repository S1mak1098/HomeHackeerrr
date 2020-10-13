using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SwitchServers : MonoBehaviour
{
    public GameObject[] VeryLowBattery; 
    public GameObject[] LowBattery; 
    public GameObject[] MeduimBattery; 
    public GameObject[] HighBattery; 
    public GameObject[] VeryHighBattery; 

    int LevelBtnUpdate1;
    public GameObject Server1;
    public GameObject Server2;
    public GameObject Server3;

    public Text LevelText;


    private void Start()
    {
        LevelBtnUpdate1 = PlayerPrefs.GetInt("LevelInt");
    }
    private void Update()
    {   
        if(LevelBtnUpdate1 >= 2)
        {
            for (int i = 0; i < VeryLowBattery.Length; i++)
            {
                VeryLowBattery[i].SetActive(true);
            }
        }
        if(LevelBtnUpdate1 >= 4)
        {
            for (int i = 0; i < LowBattery.Length; i++)
            {
                LowBattery[i].SetActive(true);
            }
        }
        if(LevelBtnUpdate1 >= 6)
        {
            for (int i = 0; i < MeduimBattery.Length; i++)
            {
                MeduimBattery[i].SetActive(true);
            }
        }
        if(LevelBtnUpdate1 >= 8)
        {
            for (int i = 0; i < HighBattery.Length; i++)
            {
                HighBattery[i].SetActive(true);
            }
        }
        if(LevelBtnUpdate1 >= 10)
        {
            for (int i = 0; i < VeryHighBattery.Length; i++)
            {
                VeryHighBattery[i].SetActive(true);
                Server1.SetActive(true);
            }
        }


        if(LevelBtnUpdate1 >= 12)
        {
            for (int i = 0; i < VeryLowBattery.Length; i++)
            {
                NewBattery();
                VeryLowBattery[i].SetActive(true);
            }
        }

        if(LevelBtnUpdate1 >= 14)
        {
            for (int i = 0; i < LowBattery.Length; i++)
            {
                LowBattery[i].SetActive(true);
        
            }
        }


        if(LevelBtnUpdate1 >= 16)
        {
            for (int i = 0; i < MeduimBattery.Length; i++)
            {
                MeduimBattery[i].SetActive(true);
           
            }
        }

        if(LevelBtnUpdate1 >= 18)
        {
            for (int i = 0; i < HighBattery.Length; i++)
            {
                HighBattery[i].SetActive(true);
         
            }
        }

        if(LevelBtnUpdate1 >= 20)
        {
            for (int i = 0; i < VeryHighBattery.Length; i++)
            {
                VeryHighBattery[i].SetActive(true);
                Server2.SetActive(true);

            }
        }


        if(LevelBtnUpdate1 >= 22)
        {
            for (int i = 0; i < VeryLowBattery.Length; i++)
            {
                NewBattery();
                VeryLowBattery[i].SetActive(true);
            }
        }

        if(LevelBtnUpdate1 >= 24)
        {
            for (int i = 0; i < LowBattery.Length; i++)
            {
                LowBattery[i].SetActive(true);
     
            }
        }

        if(LevelBtnUpdate1 >= 26)
        {
            for (int i = 0; i < MeduimBattery.Length; i++)
            {
                MeduimBattery[i].SetActive(true);
     
            }
        }

        if(LevelBtnUpdate1 >= 28)
        {
            for (int i = 0; i < HighBattery.Length; i++)
            {
                HighBattery[i].SetActive(true);
     
            }
        }

        if(LevelBtnUpdate1 >= 30)
        {
            for (int i = 0; i < VeryHighBattery.Length; i++)
            {
                VeryHighBattery[i].SetActive(true);
                Server3.SetActive(true);
            }
        }
        

    }
    public void UpdateBattery1()
    {
        
        //PlayerPrefs.SetInt("LevelInt", LevelBtnUpdate1);
        if(LevelBtnUpdate1 <= 30)
        {
            LevelBtnUpdate1++;
            PlayerPrefs.SetInt("LevelInt", LevelBtnUpdate1);
            LevelText.text = "Level " + LevelBtnUpdate1;
        }
        
    }


    public void NewBattery()
    {
        for (int i = 0; i < VeryLowBattery.Length; i++)
        {
            VeryLowBattery[i].SetActive(false);
        }

        for (int i = 0; i < LowBattery.Length; i++)
        {
            LowBattery[i].SetActive(false);
        }

        for (int i = 0; i < MeduimBattery.Length; i++)
        {
            MeduimBattery[i].SetActive(false);
        }

        for (int i = 0; i < HighBattery.Length; i++)
        {
            HighBattery[i].SetActive(false);
        }

        for (int i = 0; i < VeryHighBattery.Length; i++)
        {
            VeryHighBattery[i].SetActive(false);
        }
    }

}
