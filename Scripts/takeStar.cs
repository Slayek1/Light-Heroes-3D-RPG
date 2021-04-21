using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takeStar : MonoBehaviour {

	public int rotateSpeed;
	public AudioSource collectSound;
	public GameObject thisStar;
	
	// Update is called once per frame
	void Update () {
		rotateSpeed = 2;
		transform.Rotate (0, rotateSpeed, 0, Space.World);
	}
	void OnTriggerEnter() {
		collectSound.Play ();
		HP.HealthPoints+=1;
		thisStar.SetActive (false);
}
}