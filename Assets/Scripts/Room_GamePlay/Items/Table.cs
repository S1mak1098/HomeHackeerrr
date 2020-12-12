using RoomGP.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Реалиция предмета Стола
/// чтобы понять как работает,смотри класс Bed.cs
/// </summary>
public class Table : Item,IBaseItem
{
    public void Choose(SelectItem item)
    {

    }

    public void LevelUP()
    {

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
}
