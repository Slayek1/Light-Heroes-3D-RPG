using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getQ01Complete : MonoBehaviour {

	public float theDistance;
	public GameObject comandDisplay;
	public GameObject comandText;
	public GameObject uiQuest;
	public GameObject thePlayer;
	public GameObject exMark;
	public GameObject completeTrigger;

	void Update () {
		theDistance = playerCast.distanceFromObject;
	}

	void OnMouseOver() {
		if (theDistance <= 3) {
			comandDisplay.SetActive (true);
			comandText.SetActive (true);
			comandText.GetComponent<Text> ().text = "complete quest";
		}

		if (Input.GetButtonDown ("Action")) {
			if (theDistance <= 3) {
				questDecision.subQuestNumber = 0;
				exMark.SetActive (false);
				globalExp.currentExp += 100;
				comandDisplay.SetActive (false);
				comandText.SetActive (false);
				completeTrigger.SetActive (false);
			}
		}
	}
	void OnMouseExit() {
		comandDisplay.SetActive (false);
		comandText.SetActive (false);
}
}