using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Complexity
{
    Easy,
    Normal,
    Hard
}
[CreateAssetMenu(fileName = "New Mission", menuName = "Mission", order = 51)]
public class Mission : ScriptableObject
{
    // Start is called before the first frame update


    public Complexity _complexity;
    [TextArea()] public string _textMissionRus;
    [TextArea()] public string _textMissionEng;
    public int price;

}
