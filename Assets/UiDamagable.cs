using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiDamagable : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private Gradient sliderGradient;
    [SerializeField] private Image fill;

    public void InitializeSliderValues(int maxValue, int currentValue)
    {
        slider.maxValue = maxValue;
        slider.value = currentValue;

        fill.color = sliderGradient.Evaluate(slider.normalizedValue);
    }

    public void OnHealthChanged(int value)
    {
        slider.value = value;

        fill.color = sliderGradient.Evaluate(slider.normalizedValue);
    }
}
