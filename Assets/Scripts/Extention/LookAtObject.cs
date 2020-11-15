using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class LookAtObject : MonoBehaviour
{
    public GameObject obj;

    [ContextMenu("LookAt")]
    public void LookAtCamera()
    {
        Undo.RecordObject(transform, "LookAtCamera");
        gameObject.transform.LookAt(obj.transform.position);
        
    }
}
