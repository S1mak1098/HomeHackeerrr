using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Класс реализации системы выбора.
/// </summary>
public class ChooseSystem : MonoBehaviour
{
    [SerializeField] private ChooseItemData Data;//Все предметы на которыеможно тыкать в игре.


    private Item activeItem;//Предмет на который тыкнули, тоесть активный.


    void Start()
    {
        Item.OnSelectedItem += SelectedItem;//Подписываемся на события получения активного предмета
                                            //Как устроено ищите в классе Item.

    }

    void Update()
    {
        
    }

    void SelectedItem(Item item)
    {
        activeItem = item;
        activeItem.item.Choose();
    }
}
