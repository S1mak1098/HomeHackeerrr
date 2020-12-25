using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyManager : MonoBehaviour
{
    private float UpdateEnergy = 5f;
    private float Energy;

    void Start()
    {
        Energy = PlayerPrefs.GetFloat("currentEnergy");
        Debug.Log("Энергия при запуске -> " + Energy);
    }

    void Update()
    {
        if(UpdateEnergy <= 0f & Energy < 100f)
        {
            Energy += 10f;
            PlayerPrefs.SetFloat("currentEnergy", Energy);
            Debug.Log("Текущая энергия -> " + Energy);
            UpdateEnergy = 5f;
        }
        else 
        {
            UpdateEnergy -= Time.deltaTime;
            
        }
    }
}
