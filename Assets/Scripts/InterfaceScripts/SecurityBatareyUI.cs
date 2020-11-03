using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecurityBatareyUI : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private Text text;

    void ChangeAmmout(float Chance, int level)
    {
        if (level == 31) { text.text = "maximum"; } else { text.text = "Level: " + level; }
    }


    private void OnEnable()
    {
        SecurityManager.OnLevelUp += ChangeAmmout;
    }
    private void OnDisable()
    {
        SecurityManager.OnLevelUp -= ChangeAmmout;
    }
}
