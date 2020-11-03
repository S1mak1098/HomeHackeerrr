using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Класс для смены камеры, теперь не нужно вкл- выкл камеры в MenuManager
/// Достаточно использовать функцию класса ChangeRoom(int id)
/// </summary>
public class CameraChange : MonoBehaviour
{
    [SerializeField] private GameObject[] ObjectCamers;
    [SerializeField] private GameObject[] ObjectPostProcesing;

    [HideInInspector] public int ActiveIDRoom { get; private set; }//Активная комната (её ид)
    /// <summary>
    /// Функция для смены камеры и пост процесинга
    /// </summary>
    /// <param name="id">id- это номер эелемнта массива :
    /// 0 - Main Camera;
    /// 1 - Main Camera 2 Room;
    /// 2 - Main Camera 3 Room;
    /// 3 - Main Camera servers;
    /// 4 - Pc Camera;
    /// </param>
    public void ChangeRoom(int id)
    {
        for (int i = 0; i < ObjectCamers.Length; i++)
        {
            if (i != id)
            {
                if (ObjectCamers[i] != null)
                {
                    ObjectCamers[i].SetActive(false);
                }

              //  if (ObjectPostProcesing[i] != null)
              //  {
             //       ObjectPostProcesing[i].SetActive(false);
               // };
            }
            else
            {
                if (ObjectCamers[i] != null)
                {
                    ObjectCamers[i].SetActive(true);
                    ActiveIDRoom = i;
                }

                //if (ObjectPostProcesing[i] != null)
               // {
               //     ObjectPostProcesing[i].SetActive(true);
               // };
            }
        }
    }
}
