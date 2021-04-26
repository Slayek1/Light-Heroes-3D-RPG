using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swingSword : MonoBehaviour {

	public GameObject theSword;
	public int swordStatus;
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetButtonDown ("Fire1") && swordStatus == 0 && attackBlock.blockSword==0) {
			StartCoroutine (swingSwordFunction ());

		}
	}

	IEnumerator swingSwordFunction () {
		swordStatus=1; 
		theSword.GetComponent<Animation> ().Play ("weaponAnim");
		swordStatus = 2;
		yield return new WaitForSeconds (1.0f);
		swordStatus = 0;

}
}