using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ������ : MonoBehaviour
{
    [SerializeField] private TMP_Text _textValue;
    private float ������������;


    private void OnEnable()
    {
        �����������.������ += �������������;
    }
    private void OnDisable()
    {
        �����������.������ -= �������������;
    }

    private void �������������()
    {
        ������������ += 1;
        SetValue(������������);
    }

    public void SetValue(float value)
    {
        _textValue.text = $"{value}";
    }
}

