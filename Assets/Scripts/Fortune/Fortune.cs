using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class Fortune : MonoBehaviour
{
    [SerializeField] private float speed;

    [SerializeField] private GameObject Whell;

    public float X, Y, Z;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (speed > 0)
        {
            //  Whell.transform.Rotate(transform.forward * -speed);
            Whell.transform.Rotate(new Vector3(X, Y, Z) * speed);
            speed -= Time.deltaTime * 4;
        }
      //  else
      //      speed = 0.5f;

    }

    private void OnTriggerStay2D (Collider2D other)
    {

        if (speed <0)
        {

            print(other.gameObject.GetComponent<Text> ().text);


        }



    }
}
