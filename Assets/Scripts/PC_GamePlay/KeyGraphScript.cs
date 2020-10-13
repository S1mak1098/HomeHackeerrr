using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyGraphScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GraphKeyScript graphKey;
    int As;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DEbug()
    {
        if(As == 0)
        {
            As++;
            gameObject.GetComponent<Image>().color = new Color(0, 1, 0, 1);
            graphKey.Number++;
            Debug.Log("ONES");
        }

    }
}
