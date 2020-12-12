using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomData
{
    public  int LevelRoom = 1;

    private  int ChairLevel = 1;
    private  int TableLevel = 1;
    private  int BedLevel = 1;
    private  int Shelf = 1;


    public  void ChairLevelUp()
    {
        ChairLevel++;
        UpdateRoomLevel();
    }
    public  void TableLevelUp()
    {
        TableLevel++;
        UpdateRoomLevel();
    }
    public  void BedLevelUp()
    {
        BedLevel++;
        UpdateRoomLevel();
    }
    public  void ComputerLevelUp()
    {
        Shelf++;
        UpdateRoomLevel();
    }

    public  bool TryComputerLevelUp()
    {
        if(LevelRoom == 1 && Shelf < 2)
        {
            return true;
        }
        if (LevelRoom == 2 && Shelf < 3)
        {
            return true;
        }
        if (LevelRoom == 3 && Shelf < 4)
        {
            return true;
        }
        if (LevelRoom == 4 && Shelf == 4)
        {
            return false;
        }
        return false;
    }
    public  bool TryChairLevelUp()
    {
        if (LevelRoom == 1 && ChairLevel < 2)
        {
            return true;
        }
        if (LevelRoom == 2 && ChairLevel < 3)
        {
            return true;
        }
        if (LevelRoom == 3 && ChairLevel < 4)
        {
            return true;
        }
        if (LevelRoom == 4 && ChairLevel < 4)
        {
            return true;
        }
        return false;
    }
    public  bool TryTableLevelUp()
    {
        if (LevelRoom == 1 && TableLevel < 2)
        {
            return true;
        }
        if (LevelRoom == 2 && TableLevel < 3)
        {
            return true;
        }
        if (LevelRoom == 3 && TableLevel < 4)
        {
            return true;
        }
        if (LevelRoom == 4 && TableLevel == 4)
        {
            return false;
        }
        return false;
    }
    public  bool TryBedLevelUp()
    {
        if (LevelRoom == 1 && BedLevel < 2)
        {
            return true;
        }
        if (LevelRoom == 2 && BedLevel < 3)
        {
            return true;
        }
        if (LevelRoom == 3 && TableLevel < 4)
        {
            return true;
        }
        if (LevelRoom == 4 && BedLevel == 4)
        {
            return false;
        }
        return false;
    }


    public void SetLevelRoom(int l)
    {
        LevelRoom = l;
    }
    private void UpdateRoomLevel()
    {
        if(ChairLevel==2 && BedLevel == 2 && TableLevel == 2 && Shelf == 2)
        {
            LevelRoom = 2;
        }
        if (ChairLevel == 3 && BedLevel == 3 && TableLevel == 3 && Shelf == 3)
        {
            LevelRoom = 3;
        }
        if (ChairLevel == 4 && BedLevel == 4 && TableLevel == 4 && Shelf == 4)
        {
            LevelRoom = 4;
        }
    }
}
