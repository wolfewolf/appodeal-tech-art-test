using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderAnimator : MonoBehaviour
{
	public Slider slider;
	public float speed = 1f;
	public AudioSource audioSource;
	private float targetValue;
	private IEnumerator animationCourutine;

	public void AnimateFill()
    {
		slider.value = 0.3248f;
		targetValue = 1f;
		StartCoroutine(AnimateToValueCourutine());
	}

	IEnumerator AnimateToValueCourutine()
	{
		while (Mathf.Abs(targetValue - slider.value) > 0.01f)
		{
			slider.value += (targetValue - slider.value) * Time.deltaTime * speed;
			yield return null;
		}

		slider.value = targetValue;
		audioSource.Play();
	}
}
