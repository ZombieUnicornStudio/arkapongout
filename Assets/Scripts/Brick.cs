﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

	void OnCollisionEnter2D (Collision2D coll) {
		if (coll.gameObject.tag == "Ball") {
			Debug.Log("Collision!");
			Destroy(gameObject);
		}
	}
}
