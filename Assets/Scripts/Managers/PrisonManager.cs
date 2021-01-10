using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrisonManager : MonoBehaviour
{
    float _time = 30f;
    public Text Timer;
    public bool Wasted;
    public GameObject prison;

    private void Update()
    {
        if(Wasted)
        {
            prison.SetActive(true);
            TimerEnable();     
        }   
    }

    private void TimerEnable()
    {
        Timer.text = "" + (int)_time; // Присвоение к тексту 
        if(_time <= 0f) { // Истечение срока и его возобновление для последуйщих ЗАДЕРЖАНИЯХ  
            Wasted = false;
            _time = 30f;
            prison.SetActive(false);
            Debug.Log("Вы выпущены!");
            
        } else {
            _time -= Time.deltaTime; // Истечение времени
        }
    }

    public void DepositBtn() {

        int Money = PlayerPrefs.GetInt("AllMoney");

        if( Money < 300) {

            Debug.Log("Недостаточное кол-во денег для залога");

        } else {

            Money -= 300;
            PlayerPrefs.SetInt("AllMoney", Money);
            prison.SetActive(false);
            Debug.Log("Вы выпущены!");
        }
    }
}
