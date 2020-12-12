using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FortuneSwitcher : MonoBehaviour
{
    public void EnterToHome()
    {
        SceneManager.LoadScene(1);
    }
    public void EnterToFortune()
    {
        SceneManager.LoadScene(2);
    }
}
