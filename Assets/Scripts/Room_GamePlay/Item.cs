using RoomGP.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public static Action<Item> OnSelectedItem;
    public IBaseItem item;
    private int level = 0;
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        OnSelectedItem?.Invoke(this);
    }
}
