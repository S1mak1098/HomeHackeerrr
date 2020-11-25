using System.Collections;
using UnityEngine;

public class MissionGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    public Mission[] _Misions_Normal;
    public Mission[] _Misions_Easy;
    public Mission[] _Misions_Hard;

    public Mission[] _SelectMissions = new Mission[3];

    public Mission CurrentMission;

    public RectTransform Spawn;

    public GameObject windowM;

    public RectTransform Parrent;

    private GameObject _SelectMis;

    private RectTransform _CurrentTm;

    private bool ready = false;

    public GameObject PC_CAMERA;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

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

        StartCoroutine(MisionStart());
        
    }
    public void NextMission()
    {
        if (ready)
        {
            StartCoroutine(MisionNext());
        }

    }

    public void CreateMission()
    {
        ready = false;

        for(int i = 0; i < _SelectMissions.Length; i++)
        {
            _SelectMissions[i] = _Misions_Easy[Random.Range(1, 13)];
        }

        _SelectMis = Instantiate(windowM, Parrent);
        _SelectMis.GetComponent<RectTransform>().position = Spawn.position;
        WindowMission WM = _SelectMis.GetComponent<WindowMission>();
        WM.AddPropertyMission(_SelectMissions[Random.Range(1, 13)]);
        WM.BtnNext.onClick.AddListener(NextMission);

        _CurrentTm = _SelectMis.GetComponent<RectTransform>();
        StartCoroutine(MisionStart());
    }

    IEnumerator MisionStart()
    {
        while ((int)_CurrentTm.position.y != Screen.height / 2)
        {
            _CurrentTm.position = Vector2.MoveTowards(_CurrentTm.position, new Vector2(_CurrentTm.position.x, Screen.height / 2), Time.deltaTime* 600);

            yield return null;
        }
        ready = true;
    }
    IEnumerator MisionNext()
    {
        while ((int)_CurrentTm.position.y != (Screen.height / 2)*3 )
        {
            _CurrentTm.position = Vector2.MoveTowards(_CurrentTm.position, new Vector2(_CurrentTm.position.x, (Screen.height / 2) *3), Time.deltaTime*600);
            yield return null;
            Debug.Log((int)_CurrentTm.position.y);
        }
        Destroy(_SelectMis);
        CreateMission();
    }
}
