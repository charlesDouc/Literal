using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thankYou_leterControl : MonoBehaviour {

	Rigidbody2D theRigidBody;
	Vector3 mousePos;


	// ------------------------------------------
	// Use this for initialization
	// ------------------------------------------
	void Start () {
		// Talk to the rigid body
		theRigidBody = GetComponent<Rigidbody2D> ();
	}


	// ------------------------------------------
	// Update is called once per frame
	// ------------------------------------------
	void Update () {
		// Link myPos to the value of the mouse on the screen
		mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		// Since it's 2D, keep the Z axis at 15f
		mousePos.z = 15f;

		// Create a bool that track if the mouse is over the sprite
		bool overSprite = this.GetComponent<SpriteRenderer> ().bounds.Contains (mousePos);

		// If the mouse is over the sprite, simulate it
		if (overSprite) {
			//Debug.Log ("IT WORKs");
			theRigidBody.simulated = true;
		}
	}

}
