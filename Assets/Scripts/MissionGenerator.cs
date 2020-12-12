using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class MissionGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    
    public Mission[] _Misions_Studying;
    public Mission[] _Misions_Easy;
    public Mission[] _Misions_Normal;
    public Mission[] _Misions_Hard;

    public Mission[] _SelectMissions = new Mission[63];

    public Mission CurrentMission;

    public RectTransform Spawn;

    public GameObject windowM;

    public RectTransform Parrent;

    private GameObject _SelectMis;

    private RectTransform _CurrentTm;

    private bool ready = false;

    public GameObject PC_CAMERA;

    public Text LvlTxt;
    public int LevelGame = 6;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LvlTxt.text = "LEVEL " + LevelGame;
    }

    private void OnEnable()
    {
        CreateMission();
    }
    private void OnDisable()
    {
        Destroy(_SelectMis);
    }

    public void StartMission()
    {

        StartCoroutine(MissionStart());
        
    }
    public void NextMission()
    {
        if (ready)
        {
            StartCoroutine(MissionNext());
        }

    }

    public void CreateMission()
    {
        ready = false;

        
        
        for(int i = 0; i < _SelectMissions.Length; i++)
        {
            if(LevelGame>= 1 && LevelGame <= 5) { _SelectMissions[i] = _Misions_Easy[Random.Range(1,21)]; }
            if(LevelGame>= 6 && LevelGame <= 10) { _SelectMissions[i] = _Misions_Normal[Random.Range(1,19)]; }
            if(LevelGame>= 11 && LevelGame <= 20) { _SelectMissions[i] = _Misions_Hard[Random.Range(1,20)]; }

        }

        _SelectMis = Instantiate(windowM, Parrent);
        _SelectMis.GetComponent<RectTransform>().position = Spawn.position;
        WindowMission WM = _SelectMis.GetComponent<WindowMission>();

        if(LevelGame>= 1 && LevelGame <= 5){
            WM.AddPropertyMission(_SelectMissions[Random.Range(1, 21)]);
        }
        if(LevelGame>= 6 && LevelGame <= 10){
            WM.AddPropertyMission(_SelectMissions[Random.Range(1, 19)]);
        }
        if(LevelGame>= 11 && LevelGame <= 20){
            WM.AddPropertyMission(_SelectMissions[Random.Range(1, 20)]);
        }
        WM.BtnNext.onClick.AddListener(NextMission);

        _CurrentTm = _SelectMis.GetComponent<RectTransform>();
        StartCoroutine(MissionStart());
    }

    IEnumerator MissionStart()
    {
        while ((int)_CurrentTm.position.y != Screen.height / 2)
        {
            _CurrentTm.position = Vector2.MoveTowards(_CurrentTm.position, new Vector2(_CurrentTm.position.x, Screen.height / 2), Time.deltaTime* 1000);

            yield return null;
        }
        ready = true;
    }
    IEnumerator MissionNext()
    {
        while ((int)_CurrentTm.position.y != (Screen.height / 2)*3 )
        {
            _CurrentTm.position = Vector2.MoveTowards(_CurrentTm.position, new Vector2(_CurrentTm.position.x, (Screen.height / 2) *3), Time.deltaTime*1000);
            yield return null;
            Debug.Log((int)_CurrentTm.position.y);
        }
        Destroy(_SelectMis);
        CreateMission();
    }
}
