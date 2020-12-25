using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyUI : MonoBehaviour
{
    public Image img;
    private float Energy;
    void Start()
    {
        Energy = PlayerPrefs.GetFloat("currentEnergy");
    }

    void Update()
    {
        img.fillAmount = Energy/100f;
    }
}
