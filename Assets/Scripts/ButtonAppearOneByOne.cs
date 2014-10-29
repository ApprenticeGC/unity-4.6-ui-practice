using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine.UI;

public class ButtonAppearOneByOne : MonoBehaviour
{
	public List<Button> buttons;
	//private int _index;

	void Start()
	{
		StartCoroutine(ShowOneByOne());
	}

	private IEnumerator ShowOneByOne()
	{
		for (int i = 0; i < buttons.Count; ++ i)
		{
			buttons[i].gameObject.SetActive(true);
			yield return new WaitForSeconds(1.0f);
		}

		StartCoroutine(HideOneByOne());
	}

	private IEnumerator HideOneByOne()
	{
		for (int i = 0; i < buttons.Count; ++ i)
		{
			buttons[i].gameObject.SetActive(false);
			yield return new WaitForSeconds(1.0f);
		}

		StartCoroutine(ShowOneByOne());
	}
}
