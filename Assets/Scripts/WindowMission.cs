using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindowMission : MonoBehaviour
{
    // Start is called before the first frame update
    
    public Text _TextMision;
    public Text _TextPrice;
    public Text _TextComplexity;


    public GameObject PcCamera;

    public Button BtnNext;
    public Button BtnStart;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartMission()
    {
        Debug.Log("должно работать");   
        GameObject.Find("PcCamera").GetComponent<Camera>().enabled = true;
        GameObject.Find("CanvasINTERFACE").SetActive(false);
        gameObject.SetActive(false);

    }

    public void AddPropertyMission(Mission _M)
    {   
        if(PlayerPrefs.GetInt("ChoosenLanguage") == 0) { _TextMision.text = _M._textMissionRus; }
        if(PlayerPrefs.GetInt("ChoosenLanguage") == 1) { _TextMision.text = _M._textMissionEng; }
        
        _TextPrice.text = _M.price.ToString() + " $";
       // if (_M._complexity == Complexity.Study) { _TextComplexity.text = "Обучение"; _TextComplexity.color = Color.blue; }
        if (_M._complexity == Complexity.Easy) { _TextComplexity.text = "Легко"; _TextComplexity.color = Color.green; }
        if (_M._complexity == Complexity.Normal) { _TextComplexity.text = "Среднее"; _TextComplexity.color = Color.yellow; }
        if (_M._complexity == Complexity.Hard) { _TextComplexity.text = "Сложно"; _TextComplexity.color = Color.red; }
    }


}
