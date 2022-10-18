using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Стрелы : MonoBehaviour
{
    [SerializeField] private TMP_Text _textValue;
    private float СтрелыИгрока=5;

    private void OnEnable()
    {
        Снаряд.Выстрел += Выстрелить;
    }
    private void OnDisable()
    {
        ТочкаСмерти.Поймал -= Выстрелить;
    }

    private void Выстрелить()
    {
        СтрелыИгрока -= 1;
        SetValue(СтрелыИгрока);
    }
    private void ДобавитьСтрел(int кол)
    {
        СтрелыИгрока += кол;
        SetValue(СтрелыИгрока);
    }

    public void SetValue(float value)
    {
        _textValue.text = $"{value}";
    }
}
