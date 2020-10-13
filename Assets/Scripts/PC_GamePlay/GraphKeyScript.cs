using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GraphKeyScript : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> allBtn = new List<GameObject>();
    public Button[] btn;
    public GameObject GraphCanvas;
    public int Number;
    public int All;

    public Text Code;

    public bool GraphBugEn;

    void Start()
    {
        GraphBugEn = true;
        RandomBtn();
        Debug.Log(btn.Length);

        for(int j = 0; j <= btn.Length; j++)
        {
            if(btn[j].enabled == true)
            {
                All++;
                Debug.Log("This is >" +  All);  
            }
        }
    }

    void Update()
    {
        Debug.Log("mub" + Number);
        if(Number == All)
        {
            GraphBugEn = false;
            Code.color = new Color(0, 1, 0, 1);
            GraphCanvas.SetActive(false);
        }
    }
    public void RandomBtn()
    {
        for (int i = 0; i <= 3; i++)
        {

            var btn = allBtn[Random.Range(0, allBtn.Count)];
            btn.GetComponent<Image>().color = new Color(1, 0, 0, 1);
            btn.GetComponent<Button>().enabled = true;
            StartCoroutine(waitForColor(2f));
            IEnumerator waitForColor(float sec) {

                yield return new WaitForSeconds(sec);
                btn.GetComponent<Image>().color = new Color(1, 1, 1, 1);
            }
        }
    }

}
