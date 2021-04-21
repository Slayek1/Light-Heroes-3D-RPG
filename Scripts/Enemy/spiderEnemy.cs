using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spiderEnemy : MonoBehaviour {

	public int enemyHealth=10;
	public GameObject theSpider;
	public int spiderStatus;
	public int baseXp=10;
	public int calculateXp;
	public spiderAI spiderAIScript;
	public static int globalSpider;

	void Start()
	{
		spiderAIScript = GetComponent<spiderAI>();
	}
	void SetPoints(int damageAmount) {
		enemyHealth -= damageAmount;
	}

	void Update () {
		globalSpider = spiderStatus;
		if (enemyHealth <= 0) {
			if (spiderStatus == 0)
			{
				StartCoroutine (deathEnemy ());
		    }
		}
	}

	IEnumerator deathEnemy(){
		spiderAIScript.enabled = false;
		spiderStatus = 6;
		calculateXp = baseXp+GlobalLevel.currentLevel;
		Exp.currentExp += calculateXp;
		yield return new WaitForSeconds (0.2f);
		theSpider.GetComponent<Animation> ().Play ("Death");

	}

}
