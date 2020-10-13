using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextGenerator : MonoBehaviour
{
    public AimBug aimBug;
    public GraphKeyScript graphKey;
    public FastBtnScript fastBug;


    // Start is called before the first frame update
    [TextArea()]
    public string text;
    public Text _Text;
    int i = 0;
    void Start()
    {
        StartCoroutine(showText(text));        
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator showText(string text)
    {
        int i = 0;
        while (i <= text.Length)
        {

            if (Input.GetMouseButton(0) && aimBug.AimBugEn == false && graphKey.GraphBugEn == false && fastBug.FastBugEn == false)
            {
                //if (i - 150 > 0) { _Text.text = text.Substring(i-145); }
                if (i < 300)
                {
                    _Text.text = text.Substring(0, i);
                }
                else
                {
                    _Text.text = text.Substring(i - 295, i);
                }

  

                i += 5;
            }

            yield return new WaitForSeconds(0.05f);
        }
    }
}
