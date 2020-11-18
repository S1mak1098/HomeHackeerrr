using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Компонент для вывода текста на экран компьютера
/// </summary>
public class TextGenerator : MonoBehaviour
{
    [SerializeField] private AimBug aimBug;
    [SerializeField] private GraphKeyScript graphKey;
    [SerializeField] private FastBtnScript fastBug;

    private BugsManager BM;
    [TextArea()] [SerializeField] private string text;
    [SerializeField] private Text _Text;

    void Start()
    {
        BM = GetComponent<BugsManager>();
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

            if (Input.GetMouseButtonDown(0) && aimBug.AimBugEn == false && graphKey.GraphBugEn == false && fastBug.FastBugEn == false && GameObject.Find("PcCamera").GetComponent<Camera>().enabled == true)
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
                float random = Random.Range(0.00f, 100f);
                Debug.Log(random);
                if (random < 10) { BM.RandomBugs(); }
            }

            yield return new WaitForSeconds(0.1f);
        }
    }
}
