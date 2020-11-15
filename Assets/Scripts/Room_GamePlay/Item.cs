using RoomGP.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Класс предмета которого можно потыкать\выбрать
/// </summary>
public class Item : MonoBehaviour
{
    public static Action<Item> OnSelectedItem;//Сам делегат
    public IBaseItem item;//Интерфейс реализаци его наследуют уже имено предметы(кровать, стул и т.д)
    public SelectItem select = new SelectItem();
    public bool Selected = false;

    private int level = 0;//Текущий уровень, как менять модель еще хз :D.
    
    void Start()
    {

    }

    void Update()
    {
        
    }
    private void OnMouseDown()
    {

        OnSelectedItem?.Invoke(this);//Если нажали на объект, то вызываем событие.


    }
}
