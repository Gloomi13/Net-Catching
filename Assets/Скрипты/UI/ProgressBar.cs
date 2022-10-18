using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class ProgressBar : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private TMP_Text _textValue;

    public void SetValue (float value)
    {
        _image.fillAmount = value;

        var valuePercent = Mathf.RoundToInt(value * 100f);

        _textValue.text = $"{valuePercent}%";
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
            SetValue(0.6f);
    }
}
