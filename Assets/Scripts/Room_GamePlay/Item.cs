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
    public static Action<Item> OnUpdateFailed;//Сам делегат
    public IBaseItem item;//Интерфейс реализаци его наследуют уже имено предметы(кровать, стул и т.д)



    [SerializeField] protected LevelItem[] levels;
    [SerializeField] protected int level = 0;//Текущий уровень
    [SerializeField] protected string NameItem;
    [SerializeField] protected cakeslice.OutlineEffect OutlineEffect;
    [SerializeField] protected cakeslice.Outline Outline;

    void Start()
    {

    }
    protected void SelectedItem(SelectItem select)
    {
        if (NameItem == select.type)
        {
            OnSelectedItem?.Invoke(this);
            item.Choose(select);
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
                //Outline = levels;
            }
            else
            {
                levels[i].obj.SetActive(false);
            }


        }
    }
    public int GetCurrentUpdatePrice()
    {
        if (levels.Length > level + 1)
        {
            return levels[level + 1].price;
        }
        else
        {
            return -1;
        }

    }
    public string GetNameUI()
    {
        if(NameItem == "Chair")
        {
            return LangManager.Instance.Lang.Chair;
        }
        if (NameItem == "Table")
        {
            return LangManager.Instance.Lang.Table;
        }
        if (NameItem == "Bed")
        {
            return LangManager.Instance.Lang.Bed;
        }
        if (NameItem == "Computer")
        {
            return LangManager.Instance.Lang.Bed;
        }
        return "Noone";
    }

    public virtual bool TryUpLevel()
    {
        return false;
    }
}
