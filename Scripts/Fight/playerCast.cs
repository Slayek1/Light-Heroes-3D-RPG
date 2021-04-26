using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCast : MonoBehaviour {

	public static float distanceFromObject;
	public float toTarget;
	void Update () {
		RaycastHit hit;
		if (Physics.Raycast (transform.position, transform.TransformDirection (Vector3.forward), out hit)) {
			toTarget = hit.distance;
			distanceFromObject = toTarget;
		}
	}
}
