//////
/// Дата файл для перевода слов.
/// Как пользоваться :
/// 1) Добавляешь новое слово в список (14,15,16 строки )
/// 2) Вводишь значение.
/// 3) Есть менеджер для испоьзования перевода. Скрипт LangManager.cs


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu( fileName ="new LangSettings",menuName = "GameSO/LangSettings")]
public class LangluageSettings: ScriptableObject
{
    public string Chair;
    public string Table;
    public string Bed;
    public string Computer;
    public string Update;
}
