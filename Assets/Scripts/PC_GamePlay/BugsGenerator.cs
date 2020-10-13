using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugsGenerator : MonoBehaviour
{

    public enum BugType
    {
        AIM,
        Noone
    }


    public int _Timer;

    public GameObject _Bug;
    public RectTransform _Parrent;

    [SerializeField] public static bool _isBug;


    void Start()
    {
        CreateBug(BugType.AIM);
    }

    public void CreateBug(BugType Type)
    {
        if (!_isBug)
        {

            StartCoroutine(BugAim(50, _Timer));
        }
    }

    IEnumerator BugAim(int count, int time)
    {
        while (count > 0)
        {
            count--;
            var obj = Instantiate(_Bug, _Parrent);
            obj.GetComponent<RectTransform>().localScale = new Vector2(0.184f, 0.02f);
            obj.GetComponent<RectTransform>().position = new Vector2(Random.Range(-0.1f, 0.1f), Random.Range(0.09f, -0.09f));
            yield return new WaitForSeconds(time);
        }


    }
}
