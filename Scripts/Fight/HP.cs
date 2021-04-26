using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HP : MonoBehaviour {

	public static int HealthPoints;
	public int InternalHealth;
	public GameObject h1;
	public GameObject h2;
	public GameObject h3;

	void Start() {
		HealthPoints = 1;
	}
	void Update () {

		if (HealthPoints <= 0) {
			SceneManager.LoadScene (1);
		}

		InternalHealth = HealthPoints;
		if (HealthPoints == 1) {
			h1.SetActive (true);
			h2.SetActive (false);
		}
		if (HealthPoints == 2) {
			h2.SetActive (true);
			h3.SetActive(false);
		}
		if (HealthPoints == 3) {
			h3.SetActive (true);
		}
	}
}
