﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globalExp : MonoBehaviour {

	public static int currentExp;
	public int internalExp;
	// Update is called once per frame
	void Update () {
		internalExp = currentExp; 
	}
}
