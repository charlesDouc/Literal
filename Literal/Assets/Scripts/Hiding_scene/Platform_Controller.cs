﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_Controller : MonoBehaviour {

	Vector3 myPos;
	Vector3 currentPos;
	bool stayOver;

	public float yPos;
	public float speed;

	// -------------------------------------------
	// Use this for initialization
	// -------------------------------------------
	void Start () {
		stayOver = false;
	}

	// ------------------------------------------
	// Update is called once per frame
	// ------------------------------------------
	void Update () {
		currentPos = transform.position;

		// Link myPos to the value of the mouse on the screen
		myPos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		// Since it's 2D, keep the Z axis at 15f
		myPos.z = 15f;

		// Create a bool that track if the mouse is over the sprite
		//bool overSprite = this.GetComponent<SpriteRenderer> ().bounds.Contains(myPos);

		// If the mouse is over the platform and the left button of the mouse is held, drag it
		if (Input.GetButton("Fire1")) {
			stayOver = true;
		} else {
			stayOver = false;
		}


		// Transform the position of the platform on the x axis with the mouse mouvement
		if (stayOver) {
			if (currentPos.x < myPos.x) {
				currentPos.x += speed;
			}

			if (currentPos.x > myPos.x) {
				currentPos.x -= speed;
			}

			transform.position = new Vector3 (currentPos.x, yPos, 15f);
		}
	} 

}