using UnityEngine;
using UnityEngine.UI;

public class WindowMission : MonoBehaviour
{
    // Start is called before the first frame update

    public Text _TextMision;
    public Text _TextPrice;
    public Text _TextComplexity;


    private int _dangerous;

    public Button BtnNext;
    public Button BtnStart;

    private float SecurityChance;
    private float Energy;

    void Start()
    {
        SecurityChance = PlayerPrefs.GetFloat("SecurityCount");
        Energy = PlayerPrefs.GetFloat("currentEnergy");
    }

    public void StartMission()
    {
        var _mGenerator = GameObject.Find("MissionGenerator");
        _mGenerator.SetActive(false); // Выключение телефона перед взломом


        Energy -= 5f; // Минус энергия
        SecurityChance -= 50f; // Минус безопасность

        Debug.Log("Текущая безопасность -> " + SecurityChance);
        Debug.Log("Текущая энергия -> " + Energy);

        PlayerPrefs.SetFloat("SecurityCount", SecurityChance);
        PlayerPrefs.SetFloat("currentEnergy", Energy);

        GameObject.Find("PcCamera").GetComponent<Camera>().enabled = true; // Включение камеры пк
        GameObject.Find("CanvasINTERFACE").SetActive(false); // Выключение основного интерфейса
        gameObject.SetActive(false); 

    }


    public void AddPropertyMission(Mission _M)
    {
        if (PlayerPrefs.GetInt("ChoosenLanguage") == 0) { _TextMision.text = _M._textMissionRus; }
        if (PlayerPrefs.GetInt("ChoosenLanguage") == 1) { _TextMision.text = _M._textMissionEng; }

        _TextPrice.text = _M.price.ToString() + " $";
        // if (_M._complexity == Complexity.Study) { _TextComplexity.text = "Обучение"; _TextComplexity.color = Color.blue; }
        if (_M._complexity == Complexity.Easy) { _TextComplexity.text = "Легко"; _TextComplexity.color = Color.green; }
        if (_M._complexity == Complexity.Normal) { _TextComplexity.text = "Среднее"; _TextComplexity.color = Color.yellow; }
        if (_M._complexity == Complexity.Hard) { _TextComplexity.text = "Сложно"; _TextComplexity.color = Color.red; }
    }


}
