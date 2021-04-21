using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class openChest : MonoBehaviour {

	public float theDistance;
	public GameObject chest;
	public GameObject actionDisplay;
	public GameObject actionText;
	public GameObject theObjective;
	public int closeObjective;
	public GameObject getSword;
	// Update is called once per frame
	void Update () {
		theDistance = playerCast.distanceFromObject;
		if (closeObjective == 3) {
			theObjective.SetActive (true);
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
			actionText.GetComponent<Text> ().text = "Open Chest";
			actionText.SetActive (true);
			actionDisplay.SetActive (true);
		}
		if(Input.GetButtonDown("Action")) {
			if(theDistance<=3) {
				this.GetComponent<BoxCollider>().enabled=false;
				getSword.SetActive (true);
				closeObjective = 3;
				actionText.SetActive(false);
				actionDisplay.SetActive (false);
			}
		}
	}
	void OnMouseExit() {
		actionDisplay.SetActive (false);
		actionText.SetActive (false);
	}
}
