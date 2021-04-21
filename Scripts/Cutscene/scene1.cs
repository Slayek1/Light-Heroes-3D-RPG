using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scene1 : MonoBehaviour {

	public GameObject camera1;
	public GameObject camera2;
	public GameObject fadeOut;
	public GameObject fadeIn;
	public GameObject thePlayer;

	void Start () {
		StartCoroutine (CutSceneStart ());
	}

	IEnumerator CutSceneStart () {
		yield return new WaitForSeconds (5);
		camera2.SetActive (true);
		camera1.SetActive (false);
		fadeIn.SetActive (false);
		yield return new WaitForSeconds (5);
		camera2.SetActive (false);
		fadeOut.SetActive (true);
		thePlayer.SetActive (true);
		fadeIn.SetActive (true);
		fadeOut.SetActive (false);
		fadeIn.SetActive (false);
	}

}
