using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questDecision : MonoBehaviour {

	public static int activeQuestNumber;
	public int internalQuestNumber;

	public GameObject mainMark;
	public GameObject objective1Mark;
	public GameObject objective2Mark;
	public GameObject objective3Mark;
	public static int subQuestNumber;
	public int internalSubNumer;
	public GameObject Pointer;


	void Update () {
		internalQuestNumber = activeQuestNumber;
		internalSubNumer = subQuestNumber;
		Pointer.transform.LookAt (mainMark.transform);

		if (internalSubNumer == 0) {
			Pointer.SetActive (false);
		}
		else
		{
			Pointer.SetActive (true);
		}

		if(internalSubNumer==1) {
			mainMark.transform.position = objective1Mark.transform.position;
		}
		if(internalSubNumer==2) {
			mainMark.transform.position = objective2Mark.transform.position;
		}
		if(internalSubNumer==3) {
			mainMark.transform.position = objective3Mark.transform.position;
		}


	}
}
