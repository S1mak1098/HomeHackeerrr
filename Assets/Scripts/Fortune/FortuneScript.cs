using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FortuneScript : MonoBehaviour
{
    private int numberOfTurns; 
    private int WhatWeWin;

    private float speed; 
    
    private bool canWeTurn = true;

    public Text winningText;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && canWeTurn == true)
        {
            StartCoroutine(TurnTheWheel());
        }
    }

    private IEnumerator TurnTheWheel()
    {
        canWeTurn = false;
        numberOfTurns = Random.Range(130, 160); // Рандомная генерация оборотов(от 130 до 160)
        speed = 0.01f; // Начальная скорость

        for (int i = 0; i < numberOfTurns; i++)
        {
            transform.Rotate(0, 0, 15f);

            if( i > Mathf.RoundToInt(numberOfTurns * 0.5f) )
            {
                speed = 0.01f;
            }

            
            if( i > Mathf.RoundToInt(numberOfTurns * 0.7f) )
            {
                speed = 0.03f;
            }

            
            if( i > Mathf.RoundToInt(numberOfTurns * 0.9f) )
            {
                speed = 0.04f;
            }

            yield return new WaitForSeconds(speed);
        }
        
        if(Mathf.RoundToInt(transform.eulerAngles.z) % 30 != 0)
        {
            transform.Rotate(0, 0, 15f);
        }

        WhatWeWin = Mathf.RoundToInt(transform.eulerAngles.z);

        switch (WhatWeWin)
        {
            case 0: // Каждый кусок фортуны
                winningText.text = "food";  // Что мы получили
                break;
            case 30:
                winningText.text = "box"; // Что мы получили
                break;
            case 60:
                winningText.text = "gold"; // Что мы получили
                break;
            case 90:
                winningText.text = "computer"; // Что мы получили
                break; 
            case 120:
                winningText.text = "game"; // Что мы получили
                break;
            case 150:
                winningText.text = "note"; // Что мы получили
                break;
            case 180:
                winningText.text = "windows"; // Что мы получили
                break;
            case 210:
                winningText.text = "phone"; // Что мы получили
                break;
            case 240:
                winningText.text = "water"; // Что мы получили
                break;
            case 270:
                winningText.text = "glass"; // Что мы получили
                break;
            case 300:
                winningText.text = "pen"; // Что мы получили
                break;
            case 330:
                winningText.text = "case"; // Что мы получили
                break;
            case 360:
                winningText.text = "book"; // Что мы получили
                break;
        }

        canWeTurn = true;

    }

}
