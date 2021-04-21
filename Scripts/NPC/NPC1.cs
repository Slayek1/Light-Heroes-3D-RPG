using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC1 : MonoBehaviour {

	public float theDistance;
	public GameObject comandDisplay;
	public GameObject comandText;
	public GameObject thePlayer;
	public GameObject textbox;
	public GameObject npcName;
	public GameObject npcText;

		void Update () {
			theDistance = playerCast.distanceFromObject;
		}

		void OnMouseOver() {
			if (theDistance <= 3) {
				attackBlock.blockSword = 1;
			comandText.GetComponent<Text> ().text = "Talk";
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
				StartCoroutine (NPC1Active ());
				}
			}
		}
		void OnMouseExit() {
			attackBlock.blockSword = 0;
			comandDisplay.SetActive (false);
			comandText.SetActive (false);
		}
	IEnumerator NPC1Active ()
	{
		textbox.SetActive (true);
		npcName.GetComponent<Text> ().text = "Dwarf";
		npcName.SetActive (true);
		npcText.GetComponent<Text> ().text = "Welcome stranger, I have a task for you. There is a demon outside the village. Bring me his head and bback to me.";
		npcText.SetActive (true);
		yield return new WaitForSeconds (5f);
		npcName.SetActive (false);
		npcText.SetActive (false);
		textbox.SetActive (false);
		comandDisplay.SetActive (true);
		comandText.SetActive (true);
	}
}