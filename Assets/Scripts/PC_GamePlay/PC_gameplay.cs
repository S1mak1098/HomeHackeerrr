using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PC_gameplay : MonoBehaviour
{
    public GameObject clickBtn;


    void Update()
    {
        if(GameObject.Find("PcCamera").GetComponent<Camera>().enabled == true)
        {
            clickBtn.SetActive(true);
        }
        else {
            clickBtn.SetActive(false);
        }

    }
}
