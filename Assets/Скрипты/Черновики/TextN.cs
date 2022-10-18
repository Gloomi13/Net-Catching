using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextN : MonoBehaviour
{
    [SerializeField] private TMP_Text _textValue;


    public void SetValue(float value)
    {
        _textValue.text = $"{value}";
    }
}
