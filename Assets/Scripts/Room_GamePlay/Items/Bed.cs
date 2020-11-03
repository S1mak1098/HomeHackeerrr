using RoomGP.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bed : Item, IBaseItem
{
    public void Choose()
    {
        Debug.Log("Это кровать для бомжей");
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
