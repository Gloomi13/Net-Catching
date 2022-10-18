using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Деньги : MonoBehaviour
{
    [SerializeField] private TMP_Text _textValue;
    private float ДеньгиИгрока;


    private void OnEnable()
    {
        ТочкаСмерти.Поймал += ДобавитьДенег;
    }
    private void OnDisable()
    {
        ТочкаСмерти.Поймал -= ДобавитьДенег;
    }

    private void ДобавитьДенег()
    {
        ДеньгиИгрока += 1;
        SetValue(ДеньгиИгрока);
    }

    public void SetValue(float value)
    {
        _textValue.text = $"{value}";
    }
}

