using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AimDotScript : MonoBehaviour
{
    public AimBug aimBug;

    public GameObject AimDotPref;
    public Transform CanvasParent;


    private void Start()
    {
       // IEnumerator waitForDestroy(float delayDead)
       // {
      //      yield return new WaitForSeconds(delayDead);           // А это время за которое дается кликнуть на кружок, иначе он сам откинется(ну там последствия определенные)
      //      Destroy(gameObject);
      //  }
       // StartCoroutine(waitForDestroy(4f));
    }


        //// а вообще это такой пиздец, я себе весь мозг выебал
    public void DestroyAimDot() // Метод уничтожения кружка после клика
    {
        
    
        SpawnAimDot(); 
        Destroy(gameObject); // уничтожение
    }
    public void SpawnAimDot() // Спавн след. кружка после клика
    {
        Vector3 p = new Vector3(Random.Range(-251f, 417f), Random.Range(315f, -299f), -0.001f); // Рандомная позиция
        GameObject aim = Instantiate(AimDotPref, p, Quaternion.identity); // Спавн кружка
        Transform aimCanvas = GameObject.Find("AimCanvas").GetComponent<Transform>();        
        
        aim.transform.SetParent(aimCanvas, false); /// Перемещение кружка дочерним обьектом в канвас(для отображения)
    }

}
