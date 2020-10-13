using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FastBtnScript : MonoBehaviour
{
    public GameObject PolsunokBag;
    private Rigidbody2D rb;
    public Text Code;

    bool OnRight = true;

    bool CheckFlag;
    public GameObject ObjSelf;

    float speedX = -0.2f;

    public bool FastBugEn;
    
    private void Start()
    {
        FastBugEn = true;
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(OnRight) {
            speedX = 300f;
        }
        if(!OnRight) {
            speedX = -300f;
        }
        rb.velocity = new Vector2 (speedX, rb.velocity.y);
        
    }



    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.GetComponent<RightWaypoint>())
        {
            OnRight = false;
        }
        if(other.GetComponent<LeftWaypoint>())
        {
            OnRight = true;
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.GetComponent<CenterFlag>())
        {
            if(CheckFlag)
            {
                Code.color = new Color(0, 1, 0, 1);
                FastBugEn = false;
                Debug.Log("Сахарный человек");
                PolsunokBag.SetActive(false);
            }
           // if(Input.KeyCode(""))
        }
        if(other.GetComponent<As>())
        {
            if(CheckFlag)
            {
                Debug.Log("fack");
            }
        }
    }

    public void CheckingCenterFlag()
    {
        CheckFlag = true;
        StartCoroutine(waitForCheck(0.1f));
        IEnumerator waitForCheck(float sec)
        {
            yield return new WaitForSeconds(sec);
            CheckFlag = false;
        }
    }
}
