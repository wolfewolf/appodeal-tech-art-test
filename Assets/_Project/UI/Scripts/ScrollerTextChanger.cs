using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class ScrollerTextChanger : MonoBehaviour
{
    public int MaxValue = 2000;
	public Slider slider;
	public TextMeshProUGUI slidedrText;

	public void OnSliderValueChanged()
    {
		slidedrText.text = $"{ Mathf.Round(slider.value * MaxValue)} / {MaxValue}";
	}
}
