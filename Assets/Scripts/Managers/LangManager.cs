/*
========================================================== 
Класс отвечает за язык в игре.
Это не относится к миссиям, так как там своя релизация.

Как пользоваться посмотри в файле Item.cs 90 строка
==========================================================
*/




using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LangManager : UnitySingletonPersistent<LangManager>//Делаем его синглтоном дабы 
                                                                 //мы могли обращаться к нему с любого 
                                                                 //места
{

    [SerializeField] private LangluageSettings Rus;//Руский язык
    [SerializeField] private LangluageSettings Eng;

    [HideInInspector] public LangluageSettings Lang;

    public void ChangeLang(int id)//какой язык щас включен смотрим в MenuManager. Там эту функцию и вызываем.
    {
        if(id==0)
        {
            Lang = Rus;
        }
        if(id==1)
        {
            Lang = Eng;
        }
    }

    private void Start()
    {
        ChangeLang(PlayerPrefs.GetInt("ChoosenLanguage", 0));
    }
}
