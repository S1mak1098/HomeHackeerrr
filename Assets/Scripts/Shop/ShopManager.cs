using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{


    int CountPage;
    public static int Money = 0;
    public Text countMoney;

    public static Action<int> OnMoneyChange;

    
    public GameObject[] AllPages;


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



    int LevelBtn;

    int CheckPC01;//
    int CheckPC02;//
    int CheckPC03;//
    int CheckPC04;// Это нужно заменить на массивы.
    int CheckPC05;//
    int CheckPC06;//


    // Start is called before the first frame update
    void Start()
    {
        Money = PlayerPrefs.GetInt("AllMoney");
        countMoney.text = "" + Money;
        LevelBtn = PlayerPrefs.GetInt("CheckLevelServers");

        //Заменить на цикл.
        if(PlayerPrefs.GetInt("CheckingPC01") == 1) // При старте сразу проверяет купленные пк
        {
            buyPCText01.SetActive(false);
            boughtPCText01.SetActive(true);
        }
        if(PlayerPrefs.GetInt("CheckingPC02") == 1) // При старте сразу проверяет купленные пк
        {
            buyPCText02.SetActive(false);
            boughtPCText02.SetActive(true);
        }
        if(PlayerPrefs.GetInt("CheckingPC03") == 1) // При старте сразу проверяет купленные пк
        {
            buyPCText03.SetActive(false);
            boughtPCText03.SetActive(true);
        }
        if(PlayerPrefs.GetInt("CheckingPC04") == 1) // При старте сразу проверяет купленные пк
        {
            buyPCText04.SetActive(false);
            boughtPCText04.SetActive(true);
        }
        if(PlayerPrefs.GetInt("CheckingPC05") == 1) // При старте сразу проверяет купленные пк
        {
            buyPCText05.SetActive(false);
            boughtPCText05.SetActive(true);
        }
        if(PlayerPrefs.GetInt("CheckingPC06") == 1) // При старте сразу проверяет купленные пк
        {
            buyPCText06.SetActive(false);
            boughtPCText06.SetActive(true);
        }
        
    }
    public void TestEvents()
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
                AllPages[4].SetActive(false);
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
        TestEvents();
    }
    
 

    //Заменить на интерфейсы, что дальше делать, пока еще не придумал.
    public void BuyPC_01() { // Первый блок покупки пк
        Debug.Log("One PC");
        if(PlayerPrefs.GetInt("CheckingPC01") == 0 && Money >= 20000)
        {
            Money -= 20000; // Цена за покупку
            CheckPC01 = 1;
            countMoney.text = "" + Money; // Вывод кол-во бабла на экран
            PlayerPrefs.SetInt("AllMoney", Money); // Сохранение кол-во бабла
            PlayerPrefs.SetInt("CheckingPC01", CheckPC01); // Сохранение переменной, отвечающий за проверку купленного пк
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
            CheckPC02 = 1;
            countMoney.text = "" + Money; // Вывод кол-во бабла на экран
            PlayerPrefs.SetInt("AllMoney", Money); // Сохранение кол-во бабла
            PlayerPrefs.SetInt("CheckingPC02", CheckPC02); // Сохранение переменной, отвечающий за проверку купленного пк
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
            CheckPC03 = 1;
            countMoney.text = "" + Money; // Вывод кол-во бабла на экран
            PlayerPrefs.SetInt("AllMoney", Money); // Сохранение кол-во бабла
            PlayerPrefs.SetInt("CheckingPC03", CheckPC03); // Сохранение переменной, отвечающий за проверку купленного пк
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
            CheckPC04 = 1;
            countMoney.text = "" + Money; // Вывод кол-во бабла на экран
            PlayerPrefs.SetInt("AllMoney", Money); // Сохранение кол-во бабла
            PlayerPrefs.SetInt("CheckingPC04", CheckPC04); // Сохранение переменной, отвечающий за проверку купленного пк
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
            CheckPC05 = 1;
            countMoney.text = "" + Money; // Вывод кол-во бабла на экран
            PlayerPrefs.SetInt("AllMoney", Money); // Сохранение кол-во бабла
            PlayerPrefs.SetInt("CheckingPC05", CheckPC05); // Сохранение переменной, отвечающий за проверку купленного пк
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
            CheckPC06 = 1;
            countMoney.text = "" + Money; // Вывод кол-во бабла на экран
            PlayerPrefs.SetInt("AllMoney", Money); // Сохранение кол-во бабла
            PlayerPrefs.SetInt("CheckingPC016", CheckPC06); // Сохранение переменной, отвечающий за проверку купленного пк
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
