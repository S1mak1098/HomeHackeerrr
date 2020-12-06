using RoomGP.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Класс предмета которого можно потыкать\выбрать
/// </summary>
/// 
[System.Serializable]
public struct LevelItem
{
   public GameObject obj;
   public int price;
}

public class Item : MonoBehaviour
{
    public static Action<Item> OnSelectedItem;//Сам делегат
    public IBaseItem item;//Интерфейс реализаци его наследуют уже имено предметы(кровать, стул и т.д)



    [SerializeField] protected LevelItem[] levels;
    [SerializeField] protected int level = 0;//Текущий уровень, как менять модель еще хз :D.
    [SerializeField] private string NameItem;

    void Start()
    {

    }
    protected void SelectedItem(string select)
    {
        if (NameItem == select)
        {
            OnSelectedItem?.Invoke(this);
            item.Choose();
        }

    }
    protected void Init()
    {
        SelectItem.OnItemSelected += SelectedItem;

    }
    protected void ChangeModel(int id)
    {
        for(int i = 0;i<levels.Length;i++)
        {
            if (i == id)
            {
                levels[i].obj.SetActive(true);
            }
            else
            {
                levels[i].obj.SetActive(false);
            }


        }
    }

    public int GetCurrentUpdatePrice()
    {
        return levels[level + 1].price;
    }
}
