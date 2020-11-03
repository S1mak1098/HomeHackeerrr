using RoomGP.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chair : Item,IBaseItem
{
    public void Choose()
    {
        Debug.Log("А на такой стул даже бомжи не сядят");
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
