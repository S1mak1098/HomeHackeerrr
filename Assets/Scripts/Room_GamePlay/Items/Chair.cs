using RoomGP.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Реалиция предмета стула
/// чтобы понять как работает,смотри класс Bed.cs
/// </summary>
public class Chair : Item,IBaseItem
{
    public void Choose(SelectItem item)
    {
        
        Debug.Log("А на такой стул даже бомжи не сядят");

    }

    public void LevelUP()
    {
        Debug.Log("Покупаем стулл");
        if (levels.Length > level + 1)
        {
            if (ShopManager.Money >= levels[level + 1].price)
            {

                if (ChooseSystem.RData.TryChairLevelUp())
                {
                    ShopManager.Money -= levels[level + 1].price;
                    level++;
                    ChangeModel(level);
                    ChooseSystem.RData.ChairLevelUp();
                    OnSelectedItem?.Invoke(this);
                }
                else
                {
                    Debug.LogAssertion("ERROR : Не удалось проверить уровень стула");
                    OnUpdateFailed?.Invoke(this);
                }

            }
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        item = this;
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override bool TryUpLevel()
    {
        return ChooseSystem.RData.TryChairLevelUp();
    }
}
