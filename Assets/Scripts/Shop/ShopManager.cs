using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{

    int LevelBtn;
    int CountPage;
    public static int Money = 0;
    public Text countMoney;

    public static Action<int> OnMoneyChange;

    
    

    [Header("Others Buttons")]
    ////// первый блок пк///////////
    public GameObject buyPCText01;
    public GameObject boughtPCText01;

    ////// второй блок пк///////////
    public GameObject buyPCText02;
    public GameObject boughtPCText02;

    ////// третий блок пк///////////
    public GameObject buyPCText03;
    public GameObject boughtPCText03;

    ////// четвертый блок пк///////////
    public GameObject buyPCText04;
    public GameObject boughtPCText04;

    ////// пятый блок пк///////////
    public GameObject buyPCText05;
    public GameObject boughtPCText05;

    ////// шестой блок пк///////////
    public GameObject buyPCText06;
    public GameObject boughtPCText06;

    [Header("Arrays")]
    public GameObject[] AllPages;
    public int[] CheckingPc;

    


    // Start is called before the first frame update
    void Start()
    {
        Money = PlayerPrefs.GetInt("AllMoney");
        countMoney.text = "" + Money;
        LevelBtn = PlayerPrefs.GetInt("CheckLevelServers");
        

        CheckingPc[0] = PlayerPrefs.GetInt("CheckingPC01");   // 
        CheckingPc[1] = PlayerPrefs.GetInt("CheckingPC02");   //  
        CheckingPc[2] = PlayerPrefs.GetInt("CheckingPC03");   //
                                                              // >      НАЗНАЧЕНИЕ ЭЛЕМЕНТАМ МАССИВА СОХРАННЕНЫЕ ДАННЫЕ 
        CheckingPc[3] = PlayerPrefs.GetInt("CheckingPC04");   //
        CheckingPc[4] = PlayerPrefs.GetInt("CheckingPC05");   //
        CheckingPc[5] = PlayerPrefs.GetInt("CheckingPC06");   //

        for (int i = 0; i <= 6; i++)   // ПРОВЕРКА НА КУПЛЕННЫЕ ПК
        {
            if(CheckingPc[i] == 1)
            {
                if(i == 0) { buyPCText01.SetActive(false); boughtPCText01.SetActive(true); }
                if(i == 1) { buyPCText02.SetActive(false); boughtPCText02.SetActive(true); }
                if(i == 2) { buyPCText03.SetActive(false); boughtPCText03.SetActive(true); }
                if(i == 3) { buyPCText04.SetActive(false); boughtPCText04.SetActive(true); }
                if(i == 4) { buyPCText05.SetActive(false); boughtPCText05.SetActive(true); }
                if(i == 5) { buyPCText06.SetActive(false); boughtPCText06.SetActive(true); }
            }
        }
      
    }


    private void SwitcherPages()  
    {
        switch (CountPage)   
        {
            case 0:
                AllPages[0].SetActive(true);
                AllPages[1].SetActive(false);
                AllPages[2].SetActive(false);
                AllPages[3].SetActive(false);
                AllPages[4].SetActive(false);
                AllPages[5].SetActive(false);
                break;

            case 1:
                AllPages[0].SetActive(false);
                AllPages[1].SetActive(true);
                AllPages[2].SetActive(false);
                AllPages[3].SetActive(false);
                AllPages[4].SetActive(false);           // ПЕРЕКЛЮЧЕНИЕ СТРАНИЦ МАГАЗИНА
                AllPages[5].SetActive(false);
                break;
            case 2:
                AllPages[0].SetActive(false);
                AllPages[1].SetActive(false);
                AllPages[2].SetActive(true);
                AllPages[3].SetActive(false);
                AllPages[4].SetActive(false);
                AllPages[5].SetActive(false);
                break;
            case 3:
                AllPages[0].SetActive(false);
                AllPages[1].SetActive(false);
                AllPages[2].SetActive(false);
                AllPages[3].SetActive(true);
                AllPages[4].SetActive(false);
                AllPages[5].SetActive(false);
                break;
            case 4:
                AllPages[0].SetActive(false);
                AllPages[1].SetActive(false);
                AllPages[2].SetActive(false);
                AllPages[3].SetActive(false);
                AllPages[4].SetActive(true);
                AllPages[5].SetActive(false);
                break;
            case 5:
                AllPages[0].SetActive(false);
                AllPages[1].SetActive(false);
                AllPages[2].SetActive(false);
                AllPages[3].SetActive(false);
                AllPages[4].SetActive(false);
                AllPages[5].SetActive(true);
                break;

            default:
                Debug.Log("Fucksdsese");
                break;
        }
    }



    private void Update()
    {
        SwitcherPages();
    }
    
 

    //Заменить на интерфейсы, что дальше делать, пока еще не придумал.


    public void BuyPC_01() { // Первый блок покупки пк

        if(PlayerPrefs.GetInt("CheckingPC01") == 0 && Money >= 20000)
        {
            Money -= 20000; // Цена за покупку
            
            countMoney.text = "" + Money; // Вывод кол-во бабла на экран
            PlayerPrefs.SetInt("AllMoney", Money); // Сохранение кол-во бабла
           
            CheckingPc[0] = 1;
            PlayerPrefs.SetInt("CheckingPC01", CheckingPc[0]);

            buyPCText01.SetActive(false);
            boughtPCText01.SetActive(true);
        }

        if(PlayerPrefs.GetInt("CheckingPC01") == 1) 
        {
            buyPCText01.SetActive(false);
            boughtPCText01.SetActive(true);
        }
    }

    public void BuyPC_02() { // Первый блок покупки пк

        if(PlayerPrefs.GetInt("CheckingPC02") == 0 && Money >= 60000)
        {
            Money -= 60000; // Цена за покупку
           
            countMoney.text = "" + Money; // Вывод кол-во бабла на экран
            PlayerPrefs.SetInt("AllMoney", Money); // Сохранение кол-во бабла
            
            CheckingPc[1] = 1;
            PlayerPrefs.SetInt("CheckingPC02", CheckingPc[1]);

            buyPCText02.SetActive(false);
            boughtPCText02.SetActive(true);
        }

        if(PlayerPrefs.GetInt("CheckingPC02") == 1) 
        {
            buyPCText02.SetActive(false);
            boughtPCText02.SetActive(true);
        }
    }

    public void BuyPC_03() { // Первый блок покупки пк

        if(PlayerPrefs.GetInt("CheckingPC03") == 0 && Money >= 180000)
        {
            Money -= 180000; // Цена за покупку
            
            countMoney.text = "" + Money; // Вывод кол-во бабла на экран
            PlayerPrefs.SetInt("AllMoney", Money); // Сохранение кол-во бабла
            
            CheckingPc[2] = 1;
            PlayerPrefs.SetInt("CheckingPC03", CheckingPc[2]);

            buyPCText03.SetActive(false);
            boughtPCText03.SetActive(true);
        }

        if(PlayerPrefs.GetInt("CheckingPC03") == 1) 
        {
            buyPCText03.SetActive(false);
            boughtPCText03.SetActive(true);
        }
    }


    public void BuyPC_04() { // Первый блок покупки пк

        if(PlayerPrefs.GetInt("CheckingPC04") == 0 && Money >= 540000)
        {
            Money -= 540000; // Цена за покупку
            
            countMoney.text = "" + Money; // Вывод кол-во бабла на экран
            PlayerPrefs.SetInt("AllMoney", Money); // Сохранение кол-во бабла
        
            CheckingPc[3] = 1;
            PlayerPrefs.SetInt("CheckingPC04", CheckingPc[3]);

            buyPCText04.SetActive(false);
            boughtPCText04.SetActive(true);
        }

        if(PlayerPrefs.GetInt("CheckingPC04") == 1) 
        {
            buyPCText04.SetActive(false);
            boughtPCText04.SetActive(true);
        }
    }


    public void BuyPC_05() { // Первый блок покупки пк

        if(PlayerPrefs.GetInt("CheckingPC05") == 0 && Money >= 1200000)
        {
            Money -= 1200000; // Цена за покупку
           
            countMoney.text = "" + Money; // Вывод кол-во бабла на экран
            PlayerPrefs.SetInt("AllMoney", Money); // Сохранение кол-во бабла
            
            CheckingPc[4] = 1;
            PlayerPrefs.SetInt("CheckingPC05", CheckingPc[4]);
            buyPCText05.SetActive(false);
            boughtPCText05.SetActive(true);
        }

        if(PlayerPrefs.GetInt("CheckingPC05") == 1) 
        {
            buyPCText05.SetActive(false);
            boughtPCText05.SetActive(true);
        }
    }



    public void BuyPC_06() { // Первый блок покупки пк

        if(PlayerPrefs.GetInt("CheckingPC06") == 0 && Money >= 3600000)
        {
            Money -= 3600000; // Цена за покупку
            
            countMoney.text = "" + Money; // Вывод кол-во бабла на экран
            PlayerPrefs.SetInt("AllMoney", Money); // Сохранение кол-во бабла
           
            CheckingPc[5] = 1;
            PlayerPrefs.SetInt("CheckingPC06", CheckingPc[5]);

            buyPCText06.SetActive(false);
            boughtPCText06.SetActive(true);

            OnMoneyChange?.Invoke(Money);
        }

        if(PlayerPrefs.GetInt("CheckingPC06") == 1) 
        {
            buyPCText06.SetActive(false);
            boughtPCText06.SetActive(true);
        }
    }

    //------------------------------------------------------------------МЕЛКИЕ МЕТОДЫ-----------------------------------------------------------------//
    public void MoneyChange(int CurrentMoney)
    {
        countMoney.text = "" + CurrentMoney;
        PlayerPrefs.SetInt("AllMoney", CurrentMoney);
    }

    public void ClickForMoney(int Money, Text countMoney)
    {
        Money += 1000;
        PlayerPrefs.SetInt("AllMoney", Money);
        countMoney.text = "" + Money;
    }

    public void RightPage() // Следующая страница
    {
        if(CountPage < 5)
        {
            CountPage++;
        }
    } 

    public void LeftPage() // Предыдущая страница
    {
        if(CountPage > 0)
        {
            CountPage--;
        }   
    }

    private void OnEnable()
    {
        Money = PlayerPrefs.GetInt("AllMoney");
        countMoney.text = "" + Money;
        OnMoneyChange += MoneyChange;
    }


    private void OnDisable()
    {
        OnMoneyChange -= MoneyChange;
    }
    
}
