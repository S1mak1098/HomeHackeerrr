using RoomGP.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Реалиция предмета Полки
/// чтобы понять как работает,смотри класс Bed.cs
/// </summary>
public class Shelf : Item,IBaseItem
{
    public void Choose(SelectItem item)
    {
        OnOutline(item);
    }

    public void LevelUP()
    {
        Debug.Log("Покупаем стулл");
        if (levels.Length > level + 1)
        {
            if (ShopManager.Money >= levels[level + 1].price)
            {

                if (ChooseSystem.RData.TryShelfLevelUp())
                {
                    ShopManager.Money -= levels[level + 1].price;
                    level++;
                    ChangeModel(level);
                    ChooseSystem.RData.ShelfLevelUp();
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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override bool TryUpLevel()
    {
        return ChooseSystem.RData.TryShelfLevelUp();
    }
}
