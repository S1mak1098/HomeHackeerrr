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




    public static RoomData RData = new RoomData();

    void Start()
    {
        Item.OnSelectedItem += SelectedItem;//Подписываемся на события получения активного предмета
                                            //Как устроено ищите в классе Item.
        Item.OnUpdateFailed += OnUpdateFailed;
        RData.SetLevelRoom(4);
        OffAllOutlines();


        

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            OffAllOutlines();
            CheckSelectItem();
        }
    }

    private void SelectedItem(Item item)
    {
        if (item.GetCurrentUpdatePrice() > 0 && item.TryUpLevel())
        {
            Debug.Log("Сработало!!!!");
            btnUpdate.gameObject.SetActive(true);
            btnUpdate.onClick.RemoveAllListeners();
            btnUpdate.onClick.AddListener(item.item.LevelUP);
            btnUpdateText.text = LangManager.Instance.Lang.Update + " " + item.GetNameUI() + ":" + item.GetCurrentUpdatePrice();
        }
        else
        {
            btnUpdate.gameObject.SetActive(false);
            OffAllOutlines();
            Debug.Log("Что то пошло не так ://");
        }


    }

    private void OnUpdateFailed(Item item)
    {
        btnUpdate.gameObject.SetActive(false);
    }

    private void CheckSelectItem()
    {

        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {

            Transform objectHit = hit.transform;
            Debug.Log("На что мы кликнули : " + objectHit.gameObject.name);
            SelectItem item = objectHit.gameObject.GetComponent<SelectItem>();
            if (item != null)
            {
                Debug.Log("item.ItemSelected()");
                item.ItemSelected();
            }

        }
        else
        {
            // btnUpdate.gameObject.SetActive(false);
        }
    }

    private void OffAllOutlines()
    {
        for(int i =0; i<Data.outlines.Length;i++)
        {
            Data.outlines[i].eraseRenderer = true;
        }
    }
}
