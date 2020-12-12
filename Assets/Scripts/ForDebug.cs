using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForDebug : MonoBehaviour
{
    public GameObject Shop;
    private void Start()
    {
        Shop.SetActive(false);
    }

    public void Delete()
    {
        PlayerPrefs.DeleteAll();
    }
}
