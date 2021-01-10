using RoomGP.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Предмет кровати, наследуемся от предмета (так как там весь базовый функционал)
/// реализуем интерфейс, что она делает.
/// </summary>
public class Bed : Item, IBaseItem
{
    public void Choose(SelectItem item)
    {
        Debug.Log("Это кровать для бомжей");
        OnOutline(item);
    }

    public void LevelUP()
    {
        Debug.Log("Покупаем стулл");
        if (levels.Length > level + 1)
        {
            if (ShopManager.Money >= levels[level + 1].price)
            {

                if (ChooseSystem.RData.TryBedLevelUp())
                {
                    ShopManager.Money -= levels[level + 1].price;
                    level++;
                    ChangeModel(level);
                    ChooseSystem.RData.BedLevelUp();
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
        item = this;//прокидываем ссылку на базовый класс объекта, 
                    //дабы не типотизировать и вызывать методы от туда а не от сюда
        Init();

                    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override bool TryUpLevel()
    {
        return ChooseSystem.RData.TryBedLevelUp();
    }
}
