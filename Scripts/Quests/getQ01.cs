using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getQ01 : MonoBehaviour {

	public float theDistance;
	public GameObject comandDisplay;
	public GameObject comandText;
	public GameObject uiQuest;
	public GameObject thePlayer;
	public GameObject noticeCam;

	void Update () {
		theDistance = playerCast.distanceFromObject;
	}

	void OnMouseOver() {
		if (theDistance <= 3) {
			attackBlock.blockSword = 1;
			comandDisplay.SetActive (true);
			comandText.SetActive (true);
		}

		if (Input.GetButtonDown ("Action")) {
			if (theDistance <= 3) {
				attackBlock.blockSword = 2;
				Cursor.lockState = CursorLockMode.None;
				Cursor.visible = true;
				comandDisplay.SetActive (false);
				comandText.SetActive (false);
				uiQuest.SetActive (true);
				noticeCam.SetActive (true);
				thePlayer.SetActive (false);
			}
		}
	}
	void OnMouseExit() {
		attackBlock.blockSword = 0;
		comandDisplay.SetActive (false);
		comandText.SetActive (false);
}
}