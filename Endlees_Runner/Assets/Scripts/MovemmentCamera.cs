﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovemmentCamera : MonoBehaviour {

	public Transform target; //A que objeto debe seguir la camara.
	public float xOffset; //offset de la camara respecto del target en el eje x.
	public float yOffset; //	" 		" 		"  		"		"	en el eje y.

	// Update is called once per frame
	void FixedUpdate () {
		transform.position = new Vector3 (10f, yOffset, target.position.z - xOffset);
	}
}
