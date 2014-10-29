using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class ChainYield : MonoBehaviour
{
	public GameObject stateUI1;
	public GameObject stateUI2;
	public GameObject stateUI3;

	void Start()
	{
	}

	public void ActivateStates()
	{
		StartCoroutine(StartState());
	}

	private IEnumerator StartState()
	{
		yield return StartCoroutine(LinedState1());
		yield return StartCoroutine(LinedState2());
		yield return StartCoroutine(LinedState3());
	}

	private IEnumerator LinedState1()
	{
		yield return new WaitForSeconds(1.0f);

		if (stateUI1 != null)
		{
			stateUI1.SetActive(true);
		}

		yield return new WaitForSeconds(1.0f);
	}

	private IEnumerator LinedState2()
	{
		yield return new WaitForSeconds(1.0f);
		
		if (stateUI2 != null)
		{
			stateUI2.SetActive(true);
		}
		
		yield return new WaitForSeconds(1.0f);
	}

	private IEnumerator LinedState3()
	{
		yield return new WaitForSeconds(1.0f);
		
		if (stateUI3 != null)
		{
			stateUI3.SetActive(true);
		}
		
		yield return new WaitForSeconds(1.0f);
	}
}
