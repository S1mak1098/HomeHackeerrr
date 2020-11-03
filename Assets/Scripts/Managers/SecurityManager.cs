using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Класс отвечает за безопастнось и все что с ней связано
/// </summary>
public class SecurityManager : MonoBehaviour
{
    private float SecutiryChance = 10;
    private int level = 1;

    /// <summary>
    /// Событие повышения уровня (1 арг шанс, 2 арг уровень)
    /// </summary>
    
    public static Action<float ,int> OnLevelUp;
    public static Action<SecurityManager> OnSecurityFailed;//Событие когда безопастность не сработала


    public void BtnLevelUp()
    {

        if (level >= 31)
        {
            level = 31;
            SecutiryChance = 100;
        }
        else
        {

            level++;
            SecutiryChance += 2.9f;
            OnLevelUp?.Invoke(SecutiryChance, level);
        }


    }

    /// <summary>
    /// Метод загруки сохранения, на будущее
    /// </summary>
    public static void LoadSave()
    {

    }

    /// <summary>
    /// Метод сохранения, на будущее
    /// </summary>
    private void Save()
    {

    }

}


