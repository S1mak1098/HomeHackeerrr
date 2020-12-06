using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// Класс реализации системы выбора.
/// </summary>
/// 

public class ChooseSystem : MonoBehaviour
{
    [SerializeField] private ChooseItemData Data;//Все предметы на которые можно тыкать в игре.
    [SerializeField] private Button btnUpdate;
    [SerializeField] private Text btnUpdateText;
    [SerializeField] private Camera camera;

    void Start()
    {
        Item.OnSelectedItem += SelectedItem;//Подписываемся на события получения активного предмета
                                            //Как устроено ищите в классе Item.


    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            RaycastHit hit;
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                
                Transform objectHit = hit.transform;
                Debug.Log("На что мы кликнули : " + objectHit.gameObject.name);
                SelectItem item = objectHit.gameObject.GetComponent<SelectItem>();
                btnUpdate.gameObject.SetActive(false);
                if (item!=null)
                {
                    item.ItemSelected();
                    btnUpdate.gameObject.SetActive(true);
                }
            }
            else
            {   
               // btnUpdate.gameObject.SetActive(false);
            }
        }
    }

    private void SelectedItem(Item item)
    {
        Debug.Log("Сработало!!!!");
        btnUpdate.onClick.AddListener(item.item.LevelUP);
        btnUpdateText.text = "Улучшить :" + item.GetCurrentUpdatePrice();
    }
}
