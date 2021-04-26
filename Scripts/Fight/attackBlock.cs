using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackBlock : MonoBehaviour {

	public static int blockSword;
	public int internalBlock;
	// Update is called once per frame
	void Update () {
		internalBlock = blockSword;
	}
}
