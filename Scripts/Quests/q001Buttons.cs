using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class q001Buttons : MonoBehaviour {
	 
	public GameObject thePlayer;
	public GameObject noticeCam;
	public GameObject uiQuest;
	public GameObject activeQBox;
	public GameObject obj01;
	public GameObject obj02;
	public GameObject obj03;
	public GameObject exMark;
	public GameObject theNotice;
	public GameObject noticeTrigger;

	public void AcceptQuest () {
		
		thePlayer.SetActive (true);
		noticeCam.SetActive (false);
		uiQuest.SetActive (false);
		StartCoroutine (SetQuestUI ());
	}
	IEnumerator SetQuestUI ()
	{
		exMark.SetActive (false);
		theNotice.SetActive (false);
		noticeTrigger.SetActive (false);
		activeQBox.GetComponent<Text> ().text = "My first Weapon";
		obj01.GetComponent<Text> ().text = "Reach the forest";
		obj02.GetComponent<Text> ().text = "Open the chest";
		obj03.GetComponent<Text> ().text = "Take weapon!";
		questDecision.activeQuestNumber = 1;
		yield return new WaitForSeconds (0.5f);
		activeQBox.SetActive (true);
		yield return new WaitForSeconds (1);
		obj01.SetActive (true);
		yield return new WaitForSeconds (0.5f);
		obj02.SetActive (true);
		yield return new WaitForSeconds (0.5f);
		obj03.SetActive (true);
		yield return new WaitForSeconds (9);
		activeQBox.SetActive (false);
		obj01.SetActive (false);
		obj02.SetActive (false);
		obj03.SetActive (false);
	}
	public void DeclineQuest() {
		thePlayer.SetActive (true);
		noticeCam.SetActive (false);
		uiQuest.SetActive (false);
	}
}