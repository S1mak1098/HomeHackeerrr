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
    }

    public void LevelUP()
    {

    }

    // Start is called before the first frame update
     void Start()
    {
        Init();
        item = this;//прокидываем ссылку на базовый класс объекта, 
                    //дабы не типотизировать и вызывать методы от туда а не от сюда
                    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
