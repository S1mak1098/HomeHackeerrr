using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

[System.Serializable]
public class SelectItem
{

    [SerializeField] private Material selectedMaterial;
    [SerializeField] private List<Material> materials = new List<Material>();


    private List<Material> materialDefault = new List<Material>();
    private Transform ObjectTransform;
    private bool Selected = false;
    
    public void Init(GameObject _obj)
    {
        Debug.Log("Ищем материалы объекта");
        ObjectTransform = _obj.transform;

        for(int i = 0;i< ObjectTransform.childCount; i++)
        {
            Debug.Log("Имя под-объекта: " + ObjectTransform.GetChild(i).name);
            Material[] ChildrenMaterial = ObjectTransform.GetChild(i).gameObject.GetComponent<MeshRenderer>().materials;
            Debug.Log("Кол-воматериалов на объекте: " + ChildrenMaterial.Length);
            for (int j = 0;j<ChildrenMaterial.Length;j++)
            {
                Debug.Log("Добовляем материал в список : " + ChildrenMaterial[j].name);
                materials.Add(ChildrenMaterial[j]);
                materialDefault.Add(ChildrenMaterial[j]);
            }
        }


    }

    public void Change()
    {
        Selected = !Selected;
        if (Selected)
        {
            SetSelectedMarerial();
        }
        else
        {
            SetDefaultMarerial();
        }
    }
    private void SetSelectedMarerial()
    {
        for (int i = 0; i < ObjectTransform.childCount; i++)
        {
            Debug.Log("Имя под-объекта: " + ObjectTransform.GetChild(i).name);
            Material[] ChildrenMaterial = ObjectTransform.GetChild(i).gameObject.GetComponent<MeshRenderer>().materials;
            Debug.Log("Кол-воматериалов на объекте: " + ChildrenMaterial.Length);
            for (int j = 0; j < ChildrenMaterial.Length; j++)
            {
                Debug.Log("Добовляем материал : " + ChildrenMaterial[j].name);
                ChildrenMaterial[j] = selectedMaterial;
            }
            ObjectTransform.GetChild(i).gameObject.GetComponent<MeshRenderer>().materials = ChildrenMaterial;
        }
    }
    public void SetDefaultMarerial()
    {


        int materialID = 0;
        for (int i = 0; i < ObjectTransform.childCount; i++)
        {
            Debug.Log("Имя под-объекта: " + ObjectTransform.GetChild(i).name);
            Material[] ChildrenMaterial = ObjectTransform.GetChild(i).gameObject.GetComponent<MeshRenderer>().materials;
            Debug.Log("Кол-воматериалов на объекте: " + ChildrenMaterial.Length);
            for (int j = 0; j < ChildrenMaterial.Length; j++)
            {
                
                Debug.Log("Добовляем материал : " + ChildrenMaterial[j].name);
                ChildrenMaterial[j] = materialDefault[materialID];
                materialID++;
            }
            ObjectTransform.GetChild(i).gameObject.GetComponent<MeshRenderer>().materials = ChildrenMaterial;
        }
    }

}
