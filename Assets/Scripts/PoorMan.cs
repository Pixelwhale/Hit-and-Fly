﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoorMan : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)){
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0,500.0f));
		}
	}
}
