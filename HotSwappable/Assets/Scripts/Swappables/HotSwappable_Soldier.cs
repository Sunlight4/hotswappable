﻿using UnityEngine;
using System.Collections;

public class HotSwappable_Soldier : HotSwappable {

	// Use this for initialization
	void Start () {
		base.Controlled = false;
	}
	
	// Update is called once per frame
	void Update () {
	}
	public override void Control () {
		base.Control();
		if (Input.GetKey (KeyCode.W)) {
			transform.position += transform.forward / 30;
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.position -= transform.right / 30;
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.position -= transform.forward / 30;
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.position += transform.right / 30;
		}
	}
		
		
		
}
