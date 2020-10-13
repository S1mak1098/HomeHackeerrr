using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AimBug : MonoBehaviour
{
    public GameObject AimCmdPan;
    public GameObject aim_pointPref;
    public Transform CanvasParent;    
    public Text Code;
    public bool AimBugEn;

    bool CheckCompl;

    void Update()
    {
        if(CheckCompl == true)
        {
            Code.color = new Color(0, 1, 0, 1);
            AimCmdPan.SetActive(false); // Выключение вкладки с багом
        }
    }

    public void SpawnAimBtn()
    {   

        AimCmdPan.SetActive(true); // Включение вкладки
        AimBugEn = true; // Проверка начался ли баг
        Vector3 p = new Vector3(Random.Range(-251f, 417f), Random.Range(315f, -299f), -0.001f);
        GameObject aim = Instantiate(aim_pointPref, p, Quaternion.identity);   // А это начальный вызов бага(просто создает первый кружок)
        aim.transform.SetParent(CanvasParent, false);
    }
}
