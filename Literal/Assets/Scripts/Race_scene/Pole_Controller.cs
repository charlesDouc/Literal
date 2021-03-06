﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pole_Controller : MonoBehaviour {

	Vector3 myPos;
	Vector3 currentPos;
	bool stayOver;
	bool ready;


	// -------------------------------------------
	// Use this for initialization
	// -------------------------------------------
	void Start () {
		stayOver = false;
		ready = false;
	}

	// ------------------------------------------
	// Update is called once per frame
	// ------------------------------------------
	void Update () {
		currentPos = transform.position;

		// Link myPos to the value of the mouse on the screen
		// myPos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		// Since it's 2D, keep the Z axis at 15f
		// myPos.z = 15f;

		// Create a bool that track if the mouse is over the sprite
		//bool overSprite = this.GetComponent<SpriteRenderer> ().bounds.Contains(myPos);

		// If the mouse is over the platform and the left button of the mouse is held, drag it
		if (Input.GetButton("Fire1") && !stayOver && ready) {
			stayOver = true;
		} 

		if (stayOver) {
			currentPos.y += 0.05f;
		}

		transform.position = currentPos;


		// Transform the position of the platform on the x axis with the mouse mouvement
		//if (stayOver) {
		//	if (currentPos.y < myPos.y) {
		//		currentPos.y += 0.03f;
		//	}

		//	if (currentPos.y > myPos.y) {
		//		currentPos.y -= 0.03f;
		//	}

		//	transform.position = new Vector3 (-0.38f, currentPos.y, 15f);
		//}
	} 

	public void camReady() {
		ready = true;
	}

}

