using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthView : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private TMP_Text _text;

    private void Start()
    {
        _text.text = _slider.value.ToString();
    }

    public void OnValueChanged()
    {
        _text.text = _slider.value.ToString();
    }
}
