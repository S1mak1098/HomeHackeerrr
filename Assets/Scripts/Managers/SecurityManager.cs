using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Класс отвечает за безопастнось и все что с ней связано
/// </summary>
public class SecurityManager : MonoBehaviour
{
    private float SecurityChance;
    private int level = 1;

    /// <summary>
    /// Событие повышения уровня (1 арг шанс, 2 арг уровень)
    /// </summary>
    
    public static Action<float ,int> OnLevelUp;
    public static Action<SecurityManager> OnSecurityFailed;//Событие когда безопастность не сработала

    private void Start()
    {
        SecurityChance = PlayerPrefs.GetFloat("SecurityCount");
        Debug.Log("Безопасность -> " + SecurityChance);
    }
    public void BtnLevelUp()
    {

        if (level >= 31)
        {
            level = 31;
            SecurityChance = 100;
        }
        else
        {

            level++;
            SecurityChance += 2.9f;
            OnLevelUp?.Invoke(SecurityChance, level);
        }


    }


    public void PlusSec()
    {
        SecurityChance += 20f;
        PlayerPrefs.SetFloat("SecurityCount", SecurityChance);
        Debug.Log("Добавилось 20: " + SecurityChance );
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


