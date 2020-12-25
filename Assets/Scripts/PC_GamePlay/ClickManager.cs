using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour
{
    private int clickCount;
    public SecurityManager secManager;
    int randNum;
    public GameObject _interface;
    private float SecurityChance;

    public PrisonManager prisonManager;

    private void Start()
    {
    }

    private void Update()
    {

        if(clickCount == 5) {
            Formula();
            GameObject.Find("PcCamera").GetComponent<Camera>().enabled = false;
            _interface.SetActive(true);
            clickCount = 0;
        
        }
    }
    public void Clicking()
    {
        clickCount++;
        Debug.Log(clickCount);
    }

    private void Formula() {

        SecurityChance = PlayerPrefs.GetFloat("SecurityCount");
        if(SecurityChance > 0 )
        {
            Debug.Log("Свободны!");
        }
        else 
        { 
            randNum = Random.Range(0, 100);

            if(randNum > (SecurityChance * -1f))
            {
                Debug.Log("Все еще не попали!");
            }
            else
            {
                Debug.Log("Ухвачен за жопу!");
                prisonManager.Wasted = true;
            }
        }
    }
}
