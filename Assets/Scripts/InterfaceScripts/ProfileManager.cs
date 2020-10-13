using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProfileManager : MonoBehaviour
{
    public GameObject Avatar_1;
    public GameObject Avatar_2;
    public GameObject Avatar_3;
    public GameObject Avatar_4;
    public GameObject Avatar_5;

    public Text ProfileName;
    public string InputName;

    int ChoosedAvatar;
    // Start is called before the first frame update
    void Start()
    {

        ChoosedAvatar = PlayerPrefs.GetInt("IdAvatar");
        InputName = PlayerPrefs.GetString("PlayerName");
        ProfileName.text = "" + InputName;
        
        if(ChoosedAvatar == 1)
        {
            Avatar_1.SetActive(true);
            Avatar_2.SetActive(false);
            Avatar_3.SetActive(false);
            Avatar_4.SetActive(false);
            Avatar_5.SetActive(false);
        }

        if(ChoosedAvatar == 2)
        {
            Avatar_1.SetActive(false);
            Avatar_2.SetActive(true);
            Avatar_3.SetActive(false);
            Avatar_4.SetActive(false);
            Avatar_5.SetActive(false);
        }

        if(ChoosedAvatar == 3)
        {
            Avatar_1.SetActive(false);
            Avatar_2.SetActive(false);
            Avatar_3.SetActive(true);
            Avatar_4.SetActive(false);
            Avatar_5.SetActive(false);
        }

        if(ChoosedAvatar == 4)
        {
            Avatar_1.SetActive(false);
            Avatar_2.SetActive(false);
            Avatar_3.SetActive(false);
            Avatar_4.SetActive(true);
            Avatar_5.SetActive(false);
        }

        if(ChoosedAvatar == 5)
        {
            Avatar_1.SetActive(false);
            Avatar_2.SetActive(false);
            Avatar_3.SetActive(false);
            Avatar_4.SetActive(false);
            Avatar_5.SetActive(true);
        }
    }

}
