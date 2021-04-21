using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spiderAI : MonoBehaviour {

	public GameObject thePlayer;
	public float targetDistance;
	public float allowedRange=30;
	public GameObject enemy;
	public float enemySpeed;
	public int attackTrigger;
	public RaycastHit shot;
	public int dealDmg;

    void Update () {
		transform.LookAt (thePlayer.transform);
		if (Physics.Raycast (transform.position, transform.TransformDirection (Vector3.forward), out shot)) {
			targetDistance = shot.distance;
			if (targetDistance <= allowedRange) {
				enemySpeed = 0.02f;
				if (attackTrigger == 0) {
					enemy.GetComponent<Animation> ().Play ("Walk");
					transform.position = Vector3.MoveTowards (transform.position, thePlayer.transform.position, enemySpeed);
				}
			} else {
				enemySpeed = 0;
				enemy.GetComponent<Animation> ().Play ("Idle");
			}
		}
		if (attackTrigger == 1) {
			if (dealDmg == 0) {
				enemySpeed = 0;
				enemy.GetComponent<Animation> ().Play ("Attack");
				StartCoroutine (takeDmg ());
			}
		}
	}
	void OnTriggerEnter()
	{
		attackTrigger = 1;
	}
	void OnTriggerExit()
	{
		attackTrigger = 0;
	}

		IEnumerator takeDmg()
		{
		dealDmg = 2;
		yield return new WaitForSeconds (0.5f);
			if(spiderEnemy.globalSpider!=6)
			{
			HP.HealthPoints -= 1;
			}
		yield return new WaitForSeconds (0.4f);
		dealDmg = 0;
		}
	}