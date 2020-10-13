using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BugsManager : MonoBehaviour
{
    public GameObject[] AllBugs;

    public Text code;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RandomBugs()
    {
        var bugs = AllBugs[Random.Range(0, AllBugs.Length)];
        code.color = new Color(1, 0, 0, 1);
        StartCoroutine(wait());
        IEnumerator wait()
        {
            yield return new WaitForSeconds(1f);
            bugs.SetActive(true);
        }
        
    }
}
