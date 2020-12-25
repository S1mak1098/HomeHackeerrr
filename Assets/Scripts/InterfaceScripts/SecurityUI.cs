using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class SecurityUI : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private Image img;
    [SerializeField] private Text text;

    private void Update() {
        float Chance = PlayerPrefs.GetFloat("SecurityCount");
        img.fillAmount = Chance/100f;
    }

    // void ChangeAmmout(float Chance,int level )
    // {
    //     float Sec = PlayerPrefs.GetFloat("SecurityCount");
    //     img.fillAmount = Sec/100;
    //     if (level == 31) { text.text = "maximum";} else { text.text = "Level: " + level; }
    // }


    // private void OnEnable()
    // {
    //     SecurityManager.OnLevelUp += ChangeAmmout;
    // }
    // private void OnDisable()
    // {
    //     SecurityManager.OnLevelUp -= ChangeAmmout;
    // }
}
