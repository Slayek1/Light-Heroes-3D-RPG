using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class openChest1 : MonoBehaviour {

	public float theDistance;
	public GameObject fakeSword;
	public GameObject realSword;
	public GameObject actionText;
	public GameObject actionDisplay;
	public GameObject theObjective;
	public int closeObjective;
	public GameObject questComplete;
	public GameObject exMark;
	public GameObject chestBlock;

	void Update () {
		theDistance = playerCast.distanceFromObject;
		if (closeObjective == 3) {
			if (theObjective.transform.localScale.y <= 0.0f) {
				closeObjective = 0;
				theObjective.SetActive (false);
			} else {
				theObjective.transform.localScale -= new Vector3 (0.0f, 0.01f, 0.0f);
			}
		}
			
	}

	void OnMouseOver() {
		if(theDistance<=3) {
			actionText.GetComponent<Text> ().text = "Take Sword";
			actionText.SetActive (true);
			actionDisplay.SetActive (true);
		}
		if(Input.GetButtonDown("Action")) {
			if(theDistance<=3) {
				questDecision.subQuestNumber = 3;
				this.GetComponent<BoxCollider>().enabled=false;
				fakeSword.SetActive (false);
				realSword.SetActive (true);
				chestBlock.SetActive (true);
				closeObjective = 3;
				actionText.SetActive(false);
				actionDisplay.SetActive (false);
				exMark.SetActive (true);
				questComplete.SetActive (true);
			}
		}
	}
	void OnMouseExit() {
		actionDisplay.SetActive (false);
		actionText.SetActive (false);
	}
}
