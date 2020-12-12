using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class SelectItem : MonoBehaviour
{
    
    public static Action<SelectItem> OnItemSelected;
    public string type;

    public cakeslice.Outline[] outlines;
    public void ItemSelected()
    {
        OnItemSelected?.Invoke(this);
    }
}
