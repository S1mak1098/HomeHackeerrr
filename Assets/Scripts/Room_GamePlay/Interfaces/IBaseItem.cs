using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RoomGP.Interfaces
{
    public interface IBaseItem//Реализация функций предмета, что с ним сделаи
    {
         void Choose(SelectItem item);// Выбрали
         void LevelUP();// Повысили его уровень

    }
}


