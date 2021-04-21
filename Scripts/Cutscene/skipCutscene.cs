using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skipCutscene : MonoBehaviour {

	public GameObject fadeIn;
	void Start () {
		StartCoroutine(fadeQuit());
	}

	IEnumerator fadeQuit()
	{
		yield return new WaitForSeconds (1);
		fadeIn.SetActive (false);
}
}