﻿using UnityEngine;
using System.Collections;

public class DeathPlaneController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision other) {
		Destroy (other.gameObject);
	}
}
