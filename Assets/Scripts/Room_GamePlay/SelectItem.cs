using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class SelectItem : MonoBehaviour
{
    
    public static Action<string> OnItemSelected;
    [SerializeField] private string type;
    public void ItemSelected()
    {
        OnItemSelected?.Invoke(type);
    }
}
