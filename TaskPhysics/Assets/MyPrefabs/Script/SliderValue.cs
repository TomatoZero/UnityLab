using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderValue : MonoBehaviour
{
    private Text obectText;
    private TextMeshProUGUI _textMeshPro;
    void Start()
    {
        _textMeshPro = GetComponent<TextMeshProUGUI>();
    }

    public void ChangeValue(float newValue)
    {
        _textMeshPro.text = newValue.ToString("0.0");
    }
}
